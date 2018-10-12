using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

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
        public YetAnotherFileFinder yaffDrive;
        public List<String> mylist = new List<String>();
        protected string finalPath;
        public void GetFilesFromSelectedDrive(YetAnotherFileFinder yaffParentForm,string path)
        {
            yaffDrive = yaffParentForm;
            DirectoryInfo d = new DirectoryInfo(@path);//Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.txt"); //Getting Text files
            string str = "";
            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
                ListViewItem lvi = new ListViewItem();
                lvi.SubItems.Add(finalPath);
                yaffDrive.lvwFiles.Items.Add(lvi);
            }
        }
        public void SetFinalPath(string path)
        {
            finalPath = path;
        }
        public void ShowResults(){
        }

        public void ConvertFile(){
        }

        public void ReadFile(){
        }
    }
}
