﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

/// <summary>
/// Drive Class. 
/// In this class, we gonna load all our drives on our computer and show it with an another method.
/// </summary>

/*
 * CHANGER
 * LES
 * TYPES VOIDS
 * MERCI
 */

namespace YetAnotherFileFinder.Class
{
    class Drives
    {
        /// <summary>
        /// 
        /// </summary>
        /// 

        private YetAnotherFileFinder yaffDrive;

        public void LoadDrive(YetAnotherFileFinder yaffParentForm){
            foreach(DriveInfo driveInfo in DriveInfo.GetDrives())
            {
                yaffDrive = yaffParentForm;
                yaffDrive.cboSelectDrive.Items.Add(driveInfo);
            }
        }

        public void LoadFolders(string selectedPath){
            Directory.GetDirectories(selectedPath);
        }   
    }
}
