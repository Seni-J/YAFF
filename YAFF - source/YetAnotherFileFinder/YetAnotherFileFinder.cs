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
        Class.Filters filter = new Class.Filters();
        
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

        private void lvwFiles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            // Check if a field has been set. Otherwise, there's a message box telling to the user that he have to put something. If a space is typed, it's like the field is not null.
            if(string.IsNullOrEmpty(txtAuthor.Text) && string.IsNullOrEmpty(txtKeyWord.Text) && string.IsNullOrEmpty(txtModifDate.Text))
            {
                MessageBox.Show("Veuillez completer un des champs pour faire une recherche avancée.","Champ(s) manquant(s).");
            }
            else
            {
                filter.CheckFilter(this);
                filter.SearchWithFilter(this);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAuthor.Clear();
            txtKeyWord.Clear();
            txtModifDate.Clear();
            file.GetFilesFromSelectedDrive(this, selectedDrive);
        }
    }
}
