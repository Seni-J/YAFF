using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

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
<<<<<<< HEAD
        
        protected string finalPath;
        public void GetFilesFromSelectedDrive(YetAnotherFileFinder yaffParentForm,string path)
        {
            
            DirectoryInfo d = new DirectoryInfo(path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.*"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
                ListViewItem lvi = new ListViewItem(str);
                lvi.Text = file.Name;
                lvi.SubItems.Add(file.Name);
                //lvi.SubItems.Add(file.Name);
                yaffParentForm.lvwFiles.Items.Add(lvi);
               
            }
=======
        public void GetFilesFromSelectedDrive(string selectedFolder){
            string[] filePaths = Directory.GetFiles(@selectedFolder,"*",SearchOption.AllDirectories);
>>>>>>> parent of b5f96d8... Revert "Revert "Merge remote-tracking branch 'origin/Dev-Jarod' into Dev-Jarod""
        }

        public void ShowResults(){
        }

        public void ConvertFile(){
        }

        public void ReadFile(){
        }
    }
}
