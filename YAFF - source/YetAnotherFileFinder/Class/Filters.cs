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
        DateTime date;
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
            if (filename != null)
            {
                foreach (ListViewItem file in yaffFilter.lvwFiles.Items)
                {
                    if (!file.Text.ToUpper().Contains(filename.ToUpper()))
                    {
                        yaffFilter.lvwFiles.Items.Remove(file);
                    }
                }
            }else if(date != null)
            {
                foreach(ListViewItem file in yaffFilter.lvwFiles.Items)
                {
                   string path = file.SubItems[1].Text + "/" + file.Text;
                   if(File.GetLastWriteTime(path).Date != date)
                    {
                        yaffFilter.lvwFiles.Items.Remove(file);
                    }
                }
            }else if(author != null)
            {
                foreach (ListViewItem file in yaffFilter.lvwFiles.Items)
                {
                    if (!file.SubItems[3].Text.ToUpper().Contains(author.ToUpper()))
                    {
                        yaffFilter.lvwFiles.Items.Remove(file);
                    }
                }
            }
        } 
    }
}
