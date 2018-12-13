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

/*
 * Form YetAnotherFileFinder
 * 
 * This is where we call methods from the class Files and the class Filters for each button. 
 *  
 * Authors: Senistan Jegarajasingam and Jarod Streckeisen.
 * Version: 1.0
 * Updated date: 13 December 2018
 */


namespace YetAnotherFileFinder
{
    public partial class YetAnotherFileFinder : Form
    {
        Class.Files file = new Class.Files();
        Class.Filters filter = new Class.Filters();
        
        public string selectedDrive;
        public string selectedFile;

        public YetAnotherFileFinder()
        {
            //Call the splashscreen form in a thread. After 1.5s, we close the splashscreen form.
            Thread t = new Thread(new ThreadStart(SplashStart));
            t.Start();
            Thread.Sleep(1500);
            InitializeComponent();
            t.Abort();
        }

        //Method to start the splashscreen.
        public void SplashStart()
        {
            splashscreen splashscreenfrm = new splashscreen();
            Application.Run(splashscreenfrm);
        }

        // On the load, we set the custom format so we won't have an error on research. We also activate the form so this form won't minimize after the splashscreen.
        private void YetAnotherFileFinder_Load(object sender, EventArgs e)
        {
            this.Activate();
            dtpDateModif.CustomFormat = " ";
        }

        // Check if a value as been selected for the calendar. If the selected date is compliant, we set a custom format for it.
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

        // Open the folder button. The repository of the selected file in the listview will be opened.
        private void btnRepo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedDrive)) {
                MessageBox.Show("Aucun répertoire n'a été sélectionné.");
            }
            else
            {
                file.LoadFolderInExplorer(lvwFiles.SelectedItems[0].SubItems[1].Text);
            }
        }

        // Open the file button. The selected file in the listview will be opened.
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

        // Cancel button. Clear all the fields when the button is clicked.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (selectedDrive != null)
            {
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

        // Select a folder button. When the button is clicked, a folder lookup form shows up and you have to select a folder. If you don't select anything, there's an error message showing up.
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

        // Research button. This button check if input filters as been set. If so, we will call the method to check if the file contains the looking field(s).
        private void btnResearch_Click(object sender, EventArgs e)
        {
            if (selectedDrive != null)
            {
                // Check if a field has been set. Otherwise, there's a message box telling to the user that he have to put something. If a space is typed, it's like the field is not null.
                if (string.IsNullOrEmpty(txtFileName.Text) && string.IsNullOrEmpty(txtAuthor.Text) && string.IsNullOrEmpty(txtKeyWord.Text) && string.IsNullOrEmpty(dtpDateModif.Text))
                {
                    MessageBox.Show("Veuillez compléter un des champs pour faire une recherche avancée.", "Champ(s) manquant(s).");
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
    }
}
