using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using FileManagement.BLL;

namespace FileManagement.Ui
{
    public partial class Lesson04CsvFileGenerateFromSqlDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        XmlCsvTxtBll aXmlCsvTxtBll = new XmlCsvTxtBll();
        protected void saveButton_Click(object sender, EventArgs e)
         {
            try
            {
                String fileName = "ProductsFileCsv.txt";
                String filePath = Server.MapPath("~\\GeneratedFiles\\") + fileName;
                StreamWriter sw = File.CreateText(filePath);
               
                // StreamWriter sw = new StreamWriter(Server.MapPath("~/ProductsFileCsv.txt"), false);
                // StreamWriter sw = new StreamWriter(Server.MapPath("~/ProductsFileCsv.csv"), false);
               
                DataTable dt = new DataTable();
                dt = aXmlCsvTxtBll.CsvAndTxtFileGenerate();
               
                int iColCount = dt.Columns.Count;
                //for (int i = 0; i < iColCount; i++)
                //{
                    //sw.Write(dt.Columns[i]);
                    //if (i < iColCount - 1)
                    //{
                    //    sw.Write(",");
                    //}
                //}
                // sw.Write(sw.NewLine);
                // Now write all the rows.
                foreach (DataRow dr in dt.Rows)
                {
                    for (int i = 0; i < iColCount; i++)
                    {
                        if (!Convert.IsDBNull(dr[i]))
                        {
                            sw.Write(dr[i].ToString());
                        }
                        if (i < iColCount - 1)
                        {      
                            sw.Write(System.Globalization.CultureInfo.CurrentCulture.TextInfo.ListSeparator);
                        }
                    }
                    sw.Write(sw.NewLine);
                }
                sw.Close();
                messageLabel.Text = "ProductsFileCsv File Generated Successfully";
            }
            catch (Exception ex)
            {
                messageLabel.Text = "Error" + ex;
            }
         }

        protected void xmlLinkButton_Click(object sender, EventArgs e)
        {
         xmlLabel.Text = "<a href=../GeneratedFiles/ProductsFileCsv.txt> View Txt file</a>";
         // xmlLabel.Text = "<a href=ProductsFileCsv.csv> View Txt file</a>";
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}