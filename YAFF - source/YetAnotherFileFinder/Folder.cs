﻿using System;
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
    public partial class frmFolder : Form
    {
        public string selectedFolder;
        public frmFolder()
        {
            InitializeComponent();
        }
        

        private void Folder_Load(object sender, EventArgs e)
        {
            
        }
        public void LoadFolder(string selectedDrive)
        {
            ListDirectory(tvFolder, selectedDrive);
            
        }
        public void ListDirectory(TreeView treeView, string path)
        {
            treeView.Nodes.Clear();
            var rootDirectoryInfo = new DirectoryInfo(path);
            treeView.Nodes.Add(CreateDirectoryNode(rootDirectoryInfo));
        }

        public static TreeNode CreateDirectoryNode(DirectoryInfo directoryInfo)
        {
            var directoryNode = new TreeNode(directoryInfo.Name);
            foreach (var directory in directoryInfo.GetDirectories())
                directoryNode.Nodes.Add(CreateDirectoryNode(directory));
            
            return directoryNode;
        }

        private void btnSelectFolder_Click_1(object sender, EventArgs e)
        {
            selectedFolder = tvFolder.SelectedNode.Text;
            Application.Exit();
        }
    }
}
