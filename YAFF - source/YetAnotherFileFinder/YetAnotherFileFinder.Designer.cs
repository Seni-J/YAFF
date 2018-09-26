﻿namespace YetAnotherFileFinder
{
    partial class YetAnotherFileFinder
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblSelectDriveHeader = new System.Windows.Forms.Label();
            this.lblInfoDrive = new System.Windows.Forms.Label();
            this.lblResearch = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblModifDate = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblExtension = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRepo = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.txtModifDate = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cboExtension = new System.Windows.Forms.ComboBox();
            this.cboSelectDrive = new System.Windows.Forms.ComboBox();
            this.lblSelectDriveText = new System.Windows.Forms.Label();
            this.lvwFiles = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSelectDriveHeader
            // 
            this.lblSelectDriveHeader.AutoSize = true;
            this.lblSelectDriveHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDriveHeader.Location = new System.Drawing.Point(44, 19);
            this.lblSelectDriveHeader.Name = "lblSelectDriveHeader";
            this.lblSelectDriveHeader.Size = new System.Drawing.Size(233, 25);
            this.lblSelectDriveHeader.TabIndex = 0;
            this.lblSelectDriveHeader.Text = "Sélectionner un lecteur";
            // 
            // lblInfoDrive
            // 
            this.lblInfoDrive.AutoSize = true;
            this.lblInfoDrive.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoDrive.Location = new System.Drawing.Point(502, 19);
            this.lblInfoDrive.Name = "lblInfoDrive";
            this.lblInfoDrive.Size = new System.Drawing.Size(219, 25);
            this.lblInfoDrive.TabIndex = 1;
            this.lblInfoDrive.Text = "Information du lecteur";
            // 
            // lblResearch
            // 
            this.lblResearch.AutoSize = true;
            this.lblResearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResearch.Location = new System.Drawing.Point(96, 128);
            this.lblResearch.Name = "lblResearch";
            this.lblResearch.Size = new System.Drawing.Size(116, 25);
            this.lblResearch.TabIndex = 2;
            this.lblResearch.Text = "Recherche";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(46, 190);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(48, 13);
            this.lblKeyword.TabIndex = 3;
            this.lblKeyword.Text = "Mot clé :";
            // 
            // lblModifDate
            // 
            this.lblModifDate.AutoSize = true;
            this.lblModifDate.Location = new System.Drawing.Point(46, 234);
            this.lblModifDate.Name = "lblModifDate";
            this.lblModifDate.Size = new System.Drawing.Size(110, 13);
            this.lblModifDate.TabIndex = 4;
            this.lblModifDate.Text = "Date de modification :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(46, 279);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(44, 13);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Auteur :";
            // 
            // lblExtension
            // 
            this.lblExtension.AutoSize = true;
            this.lblExtension.Location = new System.Drawing.Point(49, 322);
            this.lblExtension.Name = "lblExtension";
            this.lblExtension.Size = new System.Drawing.Size(59, 13);
            this.lblExtension.TabIndex = 6;
            this.lblExtension.Text = "Extension :";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(551, 128);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(88, 25);
            this.lblFiles.TabIndex = 7;
            this.lblFiles.Text = "Fichiers";
            // 
            // btnResearch
            // 
            this.btnResearch.Location = new System.Drawing.Point(49, 403);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(75, 23);
            this.btnResearch.TabIndex = 8;
            this.btnResearch.Text = "Rechercher";
            this.btnResearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(181, 402);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnRepo
            // 
            this.btnRepo.Location = new System.Drawing.Point(625, 403);
            this.btnRepo.Name = "btnRepo";
            this.btnRepo.Size = new System.Drawing.Size(138, 23);
            this.btnRepo.TabIndex = 10;
            this.btnRepo.Text = "Ouvrir le répértoire";
            this.btnRepo.UseVisualStyleBackColor = true;
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Location = new System.Drawing.Point(181, 187);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(100, 20);
            this.txtKeyWord.TabIndex = 11;
            // 
            // txtModifDate
            // 
            this.txtModifDate.Location = new System.Drawing.Point(181, 231);
            this.txtModifDate.Name = "txtModifDate";
            this.txtModifDate.Size = new System.Drawing.Size(100, 20);
            this.txtModifDate.TabIndex = 12;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(181, 276);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // cboExtension
            // 
            this.cboExtension.FormattingEnabled = true;
            this.cboExtension.Items.AddRange(new object[] {
            ".exe",
            ".jpg",
            ".png",
            ".docx",
            ".pdf",
            ".xlsx"});
            this.cboExtension.Location = new System.Drawing.Point(181, 319);
            this.cboExtension.Name = "cboExtension";
            this.cboExtension.Size = new System.Drawing.Size(100, 21);
            this.cboExtension.TabIndex = 15;
            // 
            // cboSelectDrive
            // 
            this.cboSelectDrive.FormattingEnabled = true;
            this.cboSelectDrive.Location = new System.Drawing.Point(181, 64);
            this.cboSelectDrive.Name = "cboSelectDrive";
            this.cboSelectDrive.Size = new System.Drawing.Size(100, 21);
            this.cboSelectDrive.TabIndex = 16;
            // 
            // lblSelectDriveText
            // 
            this.lblSelectDriveText.AutoSize = true;
            this.lblSelectDriveText.Location = new System.Drawing.Point(46, 67);
            this.lblSelectDriveText.Name = "lblSelectDriveText";
            this.lblSelectDriveText.Size = new System.Drawing.Size(106, 13);
            this.lblSelectDriveText.TabIndex = 17;
            this.lblSelectDriveText.Text = "Lecteur sélectionné :";
            // 
            // lvwFiles
            // 
            this.lvwFiles.Location = new System.Drawing.Point(442, 156);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(321, 227);
            this.lvwFiles.TabIndex = 18;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            // 
            // YetAnotherFileFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 460);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.lblSelectDriveText);
            this.Controls.Add(this.cboSelectDrive);
            this.Controls.Add(this.cboExtension);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtModifDate);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnRepo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblExtension);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblModifDate);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblResearch);
            this.Controls.Add(this.lblInfoDrive);
            this.Controls.Add(this.lblSelectDriveHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "YetAnotherFileFinder";
            this.Text = "YAFF - Yet Another File Finder";
            this.Load += new System.EventHandler(this.YetAnotherFileFinder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDriveHeader;
        private System.Windows.Forms.Label lblInfoDrive;
        private System.Windows.Forms.Label lblResearch;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblModifDate;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblExtension;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRepo;
        private System.Windows.Forms.TextBox txtKeyWord;
        private System.Windows.Forms.TextBox txtModifDate;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ComboBox cboExtension;
        private System.Windows.Forms.ComboBox cboSelectDrive;
        private System.Windows.Forms.Label lblSelectDriveText;
        private System.Windows.Forms.ListView lvwFiles;
    }
}
