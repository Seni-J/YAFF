using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Spire.Xls;
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
            if (yaffFilter.dtpDateModif.Text != " ")
            {
                date = yaffFilter.dtpDateModif.Value.Date;
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
            int listcount = yaffFilter.lvwFiles.Items.Count;
            yaffFilter.pgbProgess.Value = 0;
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
            }
           else if(keyWord != null)
            {
                foreach (ListViewItem file in yaffFilter.lvwFiles.Items)
                {
                    filePath = file.SubItems[1].Text;
                    extension = file.Text.Split('.');
                   
                    switch(extension.Last())
                    {
                        case "txt":

                            StreamReader sr = new StreamReader(filePath + "/" + file.Text);
                          
                            String txtstring = sr.ReadToEnd();
                            if (txtstring.Contains(keyWord))
                            {
                                yaffFilter.lvwFiles.Items.Remove(file);
                            }

                            break;
                        case "doc":
                        case "docx":
                            if (!file.Text.Contains("~")){
                                Document document = new Document();
                                document.LoadFromFile(filePath + "/" + file.Text);
                                StringBuilder sbdoc = new StringBuilder();
                                foreach (Section section in document.Sections)
                                {
                                    foreach (Paragraph paragraph in section.Paragraphs)
                                    {
                                        sbdoc.AppendLine(paragraph.Text);
                                    }
                                    if (!sbdoc.ToString().Contains(keyWord))
                                    {
                                        yaffFilter.lvwFiles.Items.Remove(file);
                                    }
                                }
                            }
                            break;
                        case "pdf":

                            StringBuilder text = new StringBuilder();
                            PdfReader pdfReader = new PdfReader(filePath + "/" + file.Text);

                            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
                            {
                                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                                string currentText = PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);

                                currentText = Encoding.UTF8.GetString(ASCIIEncoding.Convert(Encoding.Default, Encoding.UTF8, Encoding.Default.GetBytes(currentText)));
                                text.Append(currentText);
                            }
                            pdfReader.Close();

                            if (!text.ToString().Contains(keyWord))
                            {
                                yaffFilter.lvwFiles.Items.Remove(file);
                            }
                            break;
                        case "xls":
                        case "xlsx":
                            Workbook workbook = new Workbook();
                            workbook.LoadFromFile(filePath + "/" + file.Text);

                            //find and highlight excel data
                            
                            
                            int countWordInExcel = 0;
                         
                            foreach(Worksheet ws in workbook.Worksheets)
                            {
                                foreach (CellRange range in ws.FindAllString(keyWord.ToLower(), true, true))
                                {
                                    countWordInExcel++;
                                }
                                
                            }
                            if (countWordInExcel == 0)
                            {
                                yaffFilter.lvwFiles.Items.Remove(file);
                            }
                            break;

                        default:
                            yaffFilter.lvwFiles.Items.Remove(file);
                            break;
                    }
                   

                    
                }
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
