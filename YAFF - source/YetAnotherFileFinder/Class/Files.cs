﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

/*
 * CHANGER
 * LES
 * TYPES VOIDS
 * MERCI
 */


namespace YetAnotherFileFinder.Class
{
    class Files
    {
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

            foreach (FileInfo file in Files)
            {
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
            foreach (DirectoryInfo  Directory in Directories)
            {
                GetFilesFromSelectedDrive(yaffParentForm, path + "/" + Directory.Name);
            }
            yaffParentForm.lvwFiles.EndUpdate();
           
        }

        //Read the file with the associated program (associated program is fixed in the registry).
        public void ReadFile(string path){
            Process.Start(path);
        }
    }
}
