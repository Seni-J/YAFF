using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;
using Spire.Doc;
using Spire.Doc.Documents;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using Spire.Xls;


/*
 * Class Filters.cs
 * 
 * This class is used to check if we have a filter or to search with one or more filters. We also reset filters of this class with a method.
 *  
 * Authors: Senistan Jegarajasingam and Jarod Streckeisen.
 * Version: 1.0
 * Updated date: 13 December 2018
 */

namespace YetAnotherFileFinder.Class
{
    class Filters
    {
        string filename;
        DateTime? date = null;
        string keyWord;
        string filePath;
        string[] extension;
        string author;

        //As the 3 fields can be filled, We need to put them in a string so we can use them later in SearchWithFilter method.
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

        // Research with one or more filters. 
        public void SearchWithFilter(YetAnotherFileFinder yaffFilter)
        {
            yaffFilter.lvwFiles.BeginUpdate();
            
            // Progress Bar.
            int listcount = yaffFilter.lvwFiles.Items.Count;
            yaffFilter.pgbProgess.Value = 0;
            yaffFilter.pgbProgess.Maximum = listcount;
            yaffFilter.pgbProgess.Visible = true;

            // Check each file we have in the listview if the file contains a filter.
            // If the file is removed, we continue go to the next item.
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
                if (keyWord != null)
                {
                    filePath = file.SubItems[1].Text;
                    extension = file.Text.Split('.');

                    switch (extension.Last())
                    {
                        case "txt":
                            // In this case, we put the read file in a string and we check if the string contains the keyword.
                            StreamReader sr = new StreamReader(filePath + "/" + file.Text);

                            String txtstring = sr.ReadToEnd();
                            if (!txtstring.ToUpper().Contains(keyWord.ToUpper()))
                            {
                                yaffFilter.lvwFiles.Items.Remove(file);
                                continue;
                            }

                            break;
                        case "doc":
                        case "docx":
                            // In this case, we open the doc or docx file and we read in each paragraph if the word we are looking for is in there.
                            if (!file.Text.Contains("~"))
                            {
                                Document document = new Document();
                                document.LoadFromFile(filePath + "/" + file.Text);
                                StringBuilder sbdoc = new StringBuilder();
                                foreach (Section section in document.Sections)
                                {
                                    foreach (Paragraph paragraph in section.Paragraphs)
                                    {
                                        sbdoc.AppendLine(paragraph.Text);
                                    }
                                    if (!sbdoc.ToString().ToUpper().Contains(keyWord.ToUpper()))
                                    {
                                        yaffFilter.lvwFiles.Items.Remove(file);
                                        continue;
                                    }
                                }
                            }
                            break;
                        case "pdf":
                            //In this case, we open a pdf file. In this file, we read each page and we extract the text. With the extacted text, we append in a string and with this string, we check if it contains the keyword.
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

                            if (!text.ToString().ToUpper().Contains(keyWord.ToUpper()))
                            {
                                yaffFilter.lvwFiles.Items.Remove(file);
                                continue;
                            }
                            break;
                        case "xls":
                        case "xlsx":
                            // Using FreeSpire.Doc
                            Workbook workbook = new Workbook();
                            workbook.LoadFromFile(filePath + "/" + file.Text);

                            //Find and highlight excel datas.


                            int countWordInExcel = 0;

                            foreach (Worksheet ws in workbook.Worksheets)
                            {
                                foreach (CellRange range in ws.FindAllString(keyWord.ToLower(), true, true))
                                {
                                    countWordInExcel++;
                                }

                            }
                            if (countWordInExcel == 0)
                            {
                                yaffFilter.lvwFiles.Items.Remove(file);
                                continue;
                            }
                            break;

                        default:
                            yaffFilter.lvwFiles.Items.Remove(file);
                            continue;
                    }
                }

                if (date != null)
                {
                    //Check if the selected date contains (similar) to the date of the metadata.
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
                    //Basic checking of the author if the author from the metadata contains the input author.
                    if (!file.SubItems[3].Text.ToUpper().Contains(author.ToUpper()))
                    {
                        yaffFilter.lvwFiles.Items.Remove(file);
                        continue;
                    }
                }
            }
            yaffFilter.pgbProgess.Visible = false;
            yaffFilter.lvwFiles.EndUpdate();
        }

        // Reset all filters. We just destroy all values by setting it with "null".
        public void ResetFilters()
        {
            filename = null;
            date = null;
            author = null;
            keyWord = null;
        }
       
    }
}
