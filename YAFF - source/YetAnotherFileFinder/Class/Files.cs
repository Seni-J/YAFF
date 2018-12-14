using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

/*
 * Class Files.cs
 * 
 * This class is used to load the files in the listview and to get the folder where we have to look in. 
 * 
 * Authors: Senistan Jegarajasingam and Jarod Streckeisen.
 * Version: 1.0
 * Updated date: 13 December 2018
 */


namespace YetAnotherFileFinder.Class
{
    class Files
    {
        //Open the repository of the selected file in the listview. All we have to do is to call the ProcessStart to open explorer.exe.
        public void LoadFolderInExplorer(string selectedPath)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = selectedPath,
                FileName = "explorer.exe"
            };
            Process.Start(startInfo);
        }

        //Get the files from a selected drive or folder.
        public void GetFilesFromSelectedDrive(YetAnotherFileFinder yaffParentForm,string path)
        {
            yaffParentForm.lvwFiles.BeginUpdate();
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
            DirectoryInfo[] Directories = d.GetDirectories("*");

            // Workaround for the progress Bar. it won't work well since we call the same method later on but it shows to the user that the application is doing something.
            int listcount = Files.Count();
            yaffParentForm.pgbProgess.Value = 0;
            yaffParentForm.pgbProgess.Maximum = listcount;
            yaffParentForm.pgbProgess.Visible = true;

            foreach (FileInfo file in Files)
            {
                yaffParentForm.pgbProgess.Value += 1;

                var lastModified = File.GetLastWriteTime(path + "/" + file.Name);
                string user = File.GetAccessControl(path + "/" + file.Name).GetOwner(typeof(System.Security.Principal.NTAccount)).ToString();
                ListViewItem lvi = new ListViewItem();
                lvi.Text = file.Name;
                lvi.SubItems.Add(file.Directory.ToString());
                lvi.SubItems.Add(file.Length.ToString() + " octet ");
                lvi.SubItems.Add(user.ToString());
                lvi.SubItems.Add(lastModified.ToString());
                
                yaffParentForm.lvwFiles.Items.Add(lvi);
               
            }
            //If there is a folder in an folder, we get in this foreach to call back this method to get the files.
            foreach (DirectoryInfo  Directory in Directories)
            {
                GetFilesFromSelectedDrive(yaffParentForm, path + "/" + Directory.Name);
            }

            yaffParentForm.pgbProgess.Visible = false;
            yaffParentForm.lvwFiles.EndUpdate();
           
        }

        //Read the file with the associated program (associated program is fixed in the registry).
        public void ReadFile(string path){
            Process.Start(path);
        }
    }
}
