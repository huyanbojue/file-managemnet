using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using FileManagement.BLL;

namespace FileManagement.Ui
{
    public partial class Lesson07TxtFileGenerateFromSqlDatabase : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        XmlCsvTxtBll aXmlCsvTxtBll = new XmlCsvTxtBll();

        protected void saveButton_Click(object sender, EventArgs e)
        {
                String fileName = "ProductsFileTidle.txt";
                String filePath = Server.MapPath("~\\GeneratedFiles\\") + fileName;
                StreamWriter sw = File.CreateText(filePath);

                DataTable dt = new DataTable();
                dt = aXmlCsvTxtBll.CsvAndTxtFileGenerate();
               
                foreach (DataRow row in dt.Rows)
                {
                    try
                    {
                     sw.Write(row[0].ToString().Trim() + "~" + row[1].ToString().Trim() + "~" + row[2].ToString().Trim() + " ");
                    }
                    catch (Exception ex)
                    {
                    messageLabel.Text = "Error" + ex;
                    }   
                     sw.Write(sw.NewLine);
               }
               sw.Flush();    
               sw.Close();
               messageLabel.Text = "File Generated Successfully";
        }

        protected void xmlLinkButton_Click(object sender, EventArgs e)
        {
            xmlLabel.Text = "<a href=../GeneratedFiles/ProductsFileTidle.txt> View Txt file</a>";
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}