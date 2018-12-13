using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Form SplashScreen
 * 
 * A little form to show our logo at the beginning of our application.
 *  
 * Authors: Senistan Jegarajasingam.
 * Version: 1.0
 * Updated date: 11 December 2018
 */

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
