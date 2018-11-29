using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;

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
        string keyWord;
        string filePath;
        string date;
        string[] extension;
        string author;

        //As the 3 fields can be filled, We need to put them in a string so we can use them later on.
        public void CheckFilter(YetAnotherFileFinder yaffFilter)
        {
            if (!string.IsNullOrEmpty(yaffFilter.txtFileName.Text))
            {
                filename = yaffFilter.txtFileName.Text;
            }
            if (!string.IsNullOrEmpty(yaffFilter.dtpDateModif.Text))
            {
                date = yaffFilter.dtpDateModif.Text;
            }
            if (!string.IsNullOrEmpty(yaffFilter.txtAuthor.Text))
            {
                author = yaffFilter.txtAuthor.Text;
            }
            if (!string.IsNullOrEmpty(yaffFilter.txtKeyWord.Text))
            {
                keyWord = yaffFilter.txtKeyWord.Text;
               
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
            }
           else if(keyWord != null)
            {
                foreach (ListViewItem file in yaffFilter.lvwFiles.Items)
                {
                    filePath = file.SubItems[1].Text;
                    extension = file.Text.Split('.');
                   
                    switch(extension[1])
                    {
                        case "doc":
                        case "docx":
                            if (file.Text.Contains("~"){

                            }
                            Document document = new Document();
                            document.LoadFromFile(filePath + "/" + file.Text);
                            StringBuilder sb = new StringBuilder();
                            foreach (Section section in document.Sections)
                            {
                                foreach (Paragraph paragraph in section.Paragraphs)
                                {
                                    sb.AppendLine(paragraph.Text);
                                }
                                if(!sb.ToString().Contains(keyWord))
                                {
                                    yaffFilter.lvwFiles.Items.Remove(file);
                                }
                            }

                                break;
                        default:
                            yaffFilter.lvwFiles.Items.Remove(file);
                            break;
                    }
                   

                    
                }
            }
            
        } 
    }
}
