﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YetAnotherFileFinder
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
            this.TransparencyKey = Color.Blue;
            this.BackColor = Color.Blue;
        }
    }
}
