using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace YetAnotherFileFinder
{
    public partial class YetAnotherFileFinder : Form
    {
        Class.Drives drive = new Class.Drives();
        Class.Files file = new Class.Files();
        
        public string selectedDrive;

        public YetAnotherFileFinder()
        {
            InitializeComponent();
        }

        private void YetAnotherFileFinder_Load(object sender, EventArgs e)
        {
           
        }

        public void btnSelectFFD_Click(object sender, EventArgs e)
        {
            fbdFolderLookup.ShowDialog();
            selectedDrive = fbdFolderLookup.SelectedPath;
            file.GetFilesFromSelectedDrive(this, selectedDrive);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedDrive);
        }


    }
}
