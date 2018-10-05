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
        public void GetFilesFromSelectedDrive(string selectedFolder){
            string[] filePaths = Directory.GetFiles(@selectedFolder,"*",SearchOption.AllDirectories);
        }

        public void ShowResults(){
        }

        public void ConvertFile(){
        }

        public void ReadFile(){
        }
    }
}
