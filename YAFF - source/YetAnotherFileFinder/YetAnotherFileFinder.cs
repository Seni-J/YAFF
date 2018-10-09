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
        frmFolder frm2 = new frmFolder();
        public string selectedDrive;

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
                frm2.LoadFolders(selectedDrive);
                frm2.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(frm2.SelectedFolder);
        }
    }
}
