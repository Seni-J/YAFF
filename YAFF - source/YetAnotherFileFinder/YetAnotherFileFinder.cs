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

        string selectedFolder;

        public YetAnotherFileFinder()
        {
            InitializeComponent();
        }

        private void YetAnotherFileFinder_Load(object sender, EventArgs e)
        {
            drive.LoadDrive(this);
        }

        private void btnSelectFFD_Click(object sender, EventArgs e)
        {

        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            file.GetFilesFromSelectedDrive(selectedFolder);
        }
    }
}
