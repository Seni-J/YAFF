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
        public string selectedDrive;

        string selectedFolder;

        public YetAnotherFileFinder()
        {
            InitializeComponent();
        }

        private void YetAnotherFileFinder_Load(object sender, EventArgs e)
        {
            drive.LoadDrive(this);
        }

        public void btnSelectFFD_Click(object sender, EventArgs e)
        {
            
            if (cboSelectDrive.SelectedIndex > -1)
            {
                selectedDrive = cboSelectDrive.SelectedItem.ToString();
                frmFolder frm2 = new frmFolder();
                frm2.LoadFolder(selectedDrive);
                frm2.ShowDialog();
                

            }


            
        }
    }
}
