namespace YetAnotherFileFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YetAnotherFileFinder));
            this.lblSelectDriveHeader = new System.Windows.Forms.Label();
            this.lblInfoFiles = new System.Windows.Forms.Label();
            this.lblResearch = new System.Windows.Forms.Label();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.lblModifDate = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblFiles = new System.Windows.Forms.Label();
            this.btnResearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnRepo = new System.Windows.Forms.Button();
            this.txtKeyWord = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lvwFiles = new System.Windows.Forms.ListView();
            this.FilesName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FilePath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Author = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ModificationDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FileName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.lblSelectFolderFromDrive = new System.Windows.Forms.Label();
            this.btnSelectFFD = new System.Windows.Forms.Button();
            this.fbdFolderLookup = new System.Windows.Forms.FolderBrowserDialog();
            this.dtpDateModif = new System.Windows.Forms.DateTimePicker();
            this.lblFileName = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.pgbProgess = new System.Windows.Forms.ProgressBar();
            this.lblCopyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSelectDriveHeader
            // 
            this.lblSelectDriveHeader.AutoSize = true;
            this.lblSelectDriveHeader.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectDriveHeader.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDriveHeader.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblSelectDriveHeader.Location = new System.Drawing.Point(45, 23);
            this.lblSelectDriveHeader.Name = "lblSelectDriveHeader";
            this.lblSelectDriveHeader.Size = new System.Drawing.Size(261, 35);
            this.lblSelectDriveHeader.TabIndex = 0;
            this.lblSelectDriveHeader.Text = "Sélectionner un lecteur";
            // 
            // lblInfoFiles
            // 
            this.lblInfoFiles.AutoSize = true;
            this.lblInfoFiles.BackColor = System.Drawing.Color.Transparent;
            this.lblInfoFiles.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoFiles.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblInfoFiles.Location = new System.Drawing.Point(691, 23);
            this.lblInfoFiles.Name = "lblInfoFiles";
            this.lblInfoFiles.Size = new System.Drawing.Size(198, 35);
            this.lblInfoFiles.TabIndex = 1;
            this.lblInfoFiles.Text = "Liste des fichiers";
            // 
            // lblResearch
            // 
            this.lblResearch.AutoSize = true;
            this.lblResearch.BackColor = System.Drawing.Color.Transparent;
            this.lblResearch.Font = new System.Drawing.Font("Roboto Condensed", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResearch.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblResearch.Location = new System.Drawing.Point(107, 159);
            this.lblResearch.Name = "lblResearch";
            this.lblResearch.Size = new System.Drawing.Size(125, 35);
            this.lblResearch.TabIndex = 2;
            this.lblResearch.Text = "Recherche";
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.BackColor = System.Drawing.Color.Transparent;
            this.lblKeyword.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeyword.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblKeyword.Location = new System.Drawing.Point(32, 267);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(58, 20);
            this.lblKeyword.TabIndex = 3;
            this.lblKeyword.Text = "Mot clé :";
            // 
            // lblModifDate
            // 
            this.lblModifDate.AutoSize = true;
            this.lblModifDate.BackColor = System.Drawing.Color.Transparent;
            this.lblModifDate.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModifDate.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblModifDate.Location = new System.Drawing.Point(32, 310);
            this.lblModifDate.Name = "lblModifDate";
            this.lblModifDate.Size = new System.Drawing.Size(134, 20);
            this.lblModifDate.TabIndex = 4;
            this.lblModifDate.Text = "Date de modification :";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.BackColor = System.Drawing.Color.Transparent;
            this.lblAuthor.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAuthor.Location = new System.Drawing.Point(32, 356);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(54, 20);
            this.lblAuthor.TabIndex = 5;
            this.lblAuthor.Text = "Auteur :";
            // 
            // lblFiles
            // 
            this.lblFiles.AutoSize = true;
            this.lblFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiles.Location = new System.Drawing.Point(675, 189);
            this.lblFiles.Name = "lblFiles";
            this.lblFiles.Size = new System.Drawing.Size(88, 25);
            this.lblFiles.TabIndex = 7;
            this.lblFiles.Text = "Fichiers";
            // 
            // btnResearch
            // 
            this.btnResearch.BackColor = System.Drawing.Color.AliceBlue;
            this.btnResearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnResearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnResearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResearch.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnResearch.Image = ((System.Drawing.Image)(resources.GetObject("btnResearch.Image")));
            this.btnResearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResearch.Location = new System.Drawing.Point(36, 463);
            this.btnResearch.Name = "btnResearch";
            this.btnResearch.Size = new System.Drawing.Size(108, 34);
            this.btnResearch.TabIndex = 8;
            this.btnResearch.Text = "Rechercher";
            this.btnResearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnResearch.UseVisualStyleBackColor = false;
            this.btnResearch.Click += new System.EventHandler(this.btnResearch_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.AliceBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(245, 463);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(91, 34);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRepo
            // 
            this.btnRepo.BackColor = System.Drawing.Color.AliceBlue;
            this.btnRepo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepo.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRepo.Image = ((System.Drawing.Image)(resources.GetObject("btnRepo.Image")));
            this.btnRepo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepo.Location = new System.Drawing.Point(367, 463);
            this.btnRepo.Name = "btnRepo";
            this.btnRepo.Size = new System.Drawing.Size(155, 34);
            this.btnRepo.TabIndex = 10;
            this.btnRepo.Text = "Ouvrir le répértoire";
            this.btnRepo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRepo.UseVisualStyleBackColor = false;
            this.btnRepo.Click += new System.EventHandler(this.btnRepo_Click);
            // 
            // txtKeyWord
            // 
            this.txtKeyWord.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKeyWord.Location = new System.Drawing.Point(173, 264);
            this.txtKeyWord.Name = "txtKeyWord";
            this.txtKeyWord.Size = new System.Drawing.Size(166, 27);
            this.txtKeyWord.TabIndex = 11;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(173, 353);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(166, 27);
            this.txtAuthor.TabIndex = 13;
            // 
            // lvwFiles
            // 
            this.lvwFiles.BackgroundImageTiled = true;
            this.lvwFiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FilesName,
            this.FilePath,
            this.Size,
            this.Author,
            this.ModificationDate});
            this.lvwFiles.Font = new System.Drawing.Font("Roboto Condensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvwFiles.FullRowSelect = true;
            this.lvwFiles.Location = new System.Drawing.Point(367, 71);
            this.lvwFiles.Name = "lvwFiles";
            this.lvwFiles.Size = new System.Drawing.Size(828, 386);
            this.lvwFiles.TabIndex = 18;
            this.lvwFiles.UseCompatibleStateImageBehavior = false;
            this.lvwFiles.View = System.Windows.Forms.View.Details;
            // 
            // FilesName
            // 
            this.FilesName.Text = "Nom";
            this.FilesName.Width = 142;
            // 
            // FilePath
            // 
            this.FilePath.Text = "Chemin";
            this.FilePath.Width = 254;
            // 
            // Size
            // 
            this.Size.Text = "Taille";
            this.Size.Width = 107;
            // 
            // Author
            // 
            this.Author.Text = "Auteur";
            this.Author.Width = 168;
            // 
            // ModificationDate
            // 
            this.ModificationDate.Text = "Date de modification";
            this.ModificationDate.Width = 172;
            // 
            // FileName
            // 
            this.FileName.Text = "Name";
            this.FileName.Width = 197;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.Color.AliceBlue;
            this.btnOpenFile.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOpenFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFile.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenFile.Image")));
            this.btnOpenFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenFile.Location = new System.Drawing.Point(1062, 463);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(133, 34);
            this.btnOpenFile.TabIndex = 19;
            this.btnOpenFile.Text = "Ouvrir le fichier";
            this.btnOpenFile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // lblSelectFolderFromDrive
            // 
            this.lblSelectFolderFromDrive.AutoSize = true;
            this.lblSelectFolderFromDrive.BackColor = System.Drawing.Color.Transparent;
            this.lblSelectFolderFromDrive.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectFolderFromDrive.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblSelectFolderFromDrive.Location = new System.Drawing.Point(83, 71);
            this.lblSelectFolderFromDrive.Name = "lblSelectFolderFromDrive";
            this.lblSelectFolderFromDrive.Size = new System.Drawing.Size(166, 20);
            this.lblSelectFolderFromDrive.TabIndex = 20;
            this.lblSelectFolderFromDrive.Text = "Sélectionner un répertoire :";
            // 
            // btnSelectFFD
            // 
            this.btnSelectFFD.BackColor = System.Drawing.Color.AliceBlue;
            this.btnSelectFFD.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSelectFFD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFFD.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectFFD.Location = new System.Drawing.Point(113, 106);
            this.btnSelectFFD.Name = "btnSelectFFD";
            this.btnSelectFFD.Size = new System.Drawing.Size(110, 34);
            this.btnSelectFFD.TabIndex = 21;
            this.btnSelectFFD.Text = "Sélectionner...";
            this.btnSelectFFD.UseVisualStyleBackColor = false;
            this.btnSelectFFD.Click += new System.EventHandler(this.btnSelectFFD_Click);
            // 
            // dtpDateModif
            // 
            this.dtpDateModif.CustomFormat = " ";
            this.dtpDateModif.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateModif.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateModif.Location = new System.Drawing.Point(173, 305);
            this.dtpDateModif.Name = "dtpDateModif";
            this.dtpDateModif.Size = new System.Drawing.Size(166, 27);
            this.dtpDateModif.TabIndex = 23;
            this.dtpDateModif.ValueChanged += new System.EventHandler(this.dtpDateModif_ValueChanged);
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.BackColor = System.Drawing.Color.Transparent;
            this.lblFileName.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileName.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblFileName.Location = new System.Drawing.Point(32, 221);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(99, 20);
            this.lblFileName.TabIndex = 24;
            this.lblFileName.Text = "Nom du fichier :";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(173, 219);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(166, 27);
            this.txtFileName.TabIndex = 25;
            // 
            // pgbProgess
            // 
            this.pgbProgess.Location = new System.Drawing.Point(651, 241);
            this.pgbProgess.Name = "pgbProgess";
            this.pgbProgess.Size = new System.Drawing.Size(300, 33);
            this.pgbProgess.TabIndex = 26;
            this.pgbProgess.Visible = false;
            // 
            // lblCopyright
            // 
            this.lblCopyright.AutoSize = true;
            this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
            this.lblCopyright.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCopyright.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblCopyright.Location = new System.Drawing.Point(1123, 9);
            this.lblCopyright.Name = "lblCopyright";
            this.lblCopyright.Size = new System.Drawing.Size(85, 20);
            this.lblCopyright.TabIndex = 27;
            this.lblCopyright.Text = "© YAC - 2018";
            // 
            // YetAnotherFileFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1220, 523);
            this.Controls.Add(this.lblCopyright);
            this.Controls.Add(this.pgbProgess);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.dtpDateModif);
            this.Controls.Add(this.btnSelectFFD);
            this.Controls.Add(this.lblSelectFolderFromDrive);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lvwFiles);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtKeyWord);
            this.Controls.Add(this.btnRepo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnResearch);
            this.Controls.Add(this.lblFiles);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lblModifDate);
            this.Controls.Add(this.lblKeyword);
            this.Controls.Add(this.lblResearch);
            this.Controls.Add(this.lblInfoFiles);
            this.Controls.Add(this.lblSelectDriveHeader);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "YetAnotherFileFinder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YAFF - Yet Another File Finder";
            this.Load += new System.EventHandler(this.YetAnotherFileFinder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectDriveHeader;
        private System.Windows.Forms.Label lblInfoFiles;
        private System.Windows.Forms.Label lblResearch;
        private System.Windows.Forms.Label lblKeyword;
        private System.Windows.Forms.Label lblModifDate;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblFiles;
        private System.Windows.Forms.Button btnResearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnRepo;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Label lblSelectFolderFromDrive;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderLookup;
        public System.Windows.Forms.Button btnSelectFFD;
        public System.Windows.Forms.ListView lvwFiles;
        public System.Windows.Forms.TextBox txtKeyWord;
        public System.Windows.Forms.TextBox txtAuthor;
        public System.Windows.Forms.ColumnHeader FileName;
        private System.Windows.Forms.ColumnHeader FilesName;
        private System.Windows.Forms.ColumnHeader Size;
        private System.Windows.Forms.ColumnHeader Author;
        private System.Windows.Forms.ColumnHeader ModificationDate;
        public System.Windows.Forms.DateTimePicker dtpDateModif;
        private System.Windows.Forms.ColumnHeader FilePath;
        private System.Windows.Forms.Label lblFileName;
        public System.Windows.Forms.TextBox txtFileName;
        public System.Windows.Forms.ProgressBar pgbProgess;
        private System.Windows.Forms.Label lblCopyright;
    }
}

