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
using System.Threading;

namespace YetAnotherFileFinder
{
    public partial class YetAnotherFileFinder : Form
    {
        Class.Drives drive = new Class.Drives();
        Class.Files file = new Class.Files();
        Class.Filters filter = new Class.Filters();
        
        public string selectedDrive;
        public string selectedFile;

        public YetAnotherFileFinder()
        {
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(2000);
            t.Abort();
            InitializeComponent();
            
        }
        public void SplashStart()
        {
            Application.Run(new splashscreen());
        }

        private void YetAnotherFileFinder_Load(object sender, EventArgs e)
        {
            dtpDateModif.CustomFormat = " ";
        }

        public void btnSelectFFD_Click(object sender, EventArgs e)
        {
            fbdFolderLookup.ShowDialog();
            if (fbdFolderLookup.SelectedPath == "")
            {
                MessageBox.Show("Veuillez sélectionner un répertoire.", "Répertoire non sélectionnée.");
            }
            else
            {
                selectedDrive = fbdFolderLookup.SelectedPath;
                lvwFiles.Items.Clear();
                file.GetFilesFromSelectedDrive(this, selectedDrive);
            }

        }

        private void btnResearch_Click(object sender, EventArgs e)
        {
            if(selectedDrive != null) { 
                // Check if a field has been set. Otherwise, there's a message box telling to the user that he have to put something. If a space is typed, it's like the field is not null.
                if(string.IsNullOrEmpty(txtAuthor.Text) && string.IsNullOrEmpty(txtKeyWord.Text) && string.IsNullOrEmpty(dtpDateModif.Text))
                {
                    MessageBox.Show("Veuillez compléter un des champs pour faire une recherche avancée.","Champ(s) manquant(s).");
                }
                else
                {
                    
                    filter.CheckFilter(this);
                    filter.SearchWithFilter(this);
                }
            }
            else
            {
                MessageBox.Show("Aucun répértoire n'a été séléctionné.");
            }
        }

        // Cancel button. Clear all the fields.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(selectedDrive != null) { 
                txtAuthor.Clear();
                txtKeyWord.Clear();
                txtFileName.Clear();
                txtFileName.Text = "";
                txtKeyWord.Text = "";
                txtAuthor.Text = "";
                dtpDateModif.CustomFormat = " ";
                lvwFiles.Items.Clear();
                pgbProgess.Visible = false;
                pgbProgess.Value = 0;
                filter.ResetFilters();
                file.GetFilesFromSelectedDrive(this, selectedDrive);
            }
            else
            {
                MessageBox.Show("Aucun répértoire n'a été séléctionné.");
            }
        }

        // Check if a value as been selected for the calendar.
        private void dtpDateModif_ValueChanged(object sender, EventArgs e)
        {
            if(dtpDateModif.Value.Date > DateTime.Today)
            {
                dtpDateModif.CustomFormat = " ";
                MessageBox.Show("Vous ne pouvez pas sélectionner une date ultérieure.");
            }
            else
            {
                dtpDateModif.CustomFormat = "dd-MM-yyyy";
            }
        }

        private void btnRepo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDrive)) {
                MessageBox.Show("Aucun répertoire n'a été sélectionné.");
            }
            else
            {
                drive.LoadFolderInExplorer(lvwFiles.SelectedItems[0].SubItems[1].Text);
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            selectedFile = lvwFiles.SelectedItems[0].Text;
            if (string.IsNullOrEmpty(selectedDrive))
            {
                MessageBox.Show("Aucun répertoire n'a été sélectionné.");
            }else if (string.IsNullOrEmpty(selectedDrive)){
                MessageBox.Show("Aucun fichier n'a été sélectionné.");
            }
            else
            {
                file.ReadFile(lvwFiles.SelectedItems[0].SubItems[1].Text + "/" + lvwFiles.SelectedItems[0].Text);   
            }
        }
    }
}
