using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Linq;

/*
 * CHANGER
 * LES
 * TYPES VOIDS
 * MERCI
 */

namespace YetAnotherFileFinder.Class
{
    class Filters
    {
        string filename;
        DateTime? date = null;
        string author;

        //As the 3 fields can be filled, We need to put them in a string so we can use them later on.
        public void CheckFilter(YetAnotherFileFinder yaffFilter)
        {
            if (!string.IsNullOrEmpty(yaffFilter.txtFileName.Text))
            {
                filename = yaffFilter.txtFileName.Text;
            }
            if (yaffFilter.dtpDateModif.Text != " ")
            {
                date = yaffFilter.dtpDateModif.Value.Date;
            }
            if (!string.IsNullOrEmpty(yaffFilter.txtAuthor.Text))
            {
                author = yaffFilter.txtAuthor.Text;
            }
        }

        public void SearchWithFilter(YetAnotherFileFinder yaffFilter)
        {
            int listcount = yaffFilter.lvwFiles.Items.Count;
            yaffFilter.pgbProgess.Maximum = listcount;
            yaffFilter.pgbProgess.Visible = true;
            foreach (ListViewItem file in yaffFilter.lvwFiles.Items)
            {
                yaffFilter.pgbProgess.Value += 1;
                if (filename != null)
                {
                    if (!file.Text.ToUpper().Contains(filename.ToUpper()))
                    {
                        yaffFilter.lvwFiles.Items.Remove(file);
                        continue;
                    }
                }
                if (date != null)
                {
                    string path = file.SubItems[1].Text + "/" + file.Text;
                    string[] dateNoTime = date.ToString().Split(' ');
                    if (!file.SubItems[4].Text.Contains(dateNoTime[0]))
                    {
                        yaffFilter.lvwFiles.Items.Remove(file);
                        continue;
                    }
                }
                if (author != null)
                {
                    if (!file.SubItems[3].Text.ToUpper().Contains(author.ToUpper()))
                    {
                        yaffFilter.lvwFiles.Items.Remove(file);
                        continue;
                    }
                }
            } 
        }

        public void ResetFilters()
        {
            filename = null;
            date = null;
            author = null;
        }
       
    }
}
