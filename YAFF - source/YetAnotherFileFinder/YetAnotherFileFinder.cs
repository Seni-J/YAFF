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
            if(cboSelectDrive.SelectedIndex > -1)
            {
                drive.LoadFolders(cboSelectDrive.ToString());
            }
        }
    }
}
