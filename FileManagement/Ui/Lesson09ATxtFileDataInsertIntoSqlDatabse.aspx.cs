using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using FileManagement.BLL;

namespace FileManagement.Ui
{
    public partial class Lesson09ATxtFileDataInsertIntoSqlDatabse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
       
        XmlCsvTxtBll aXmlCsvTxtBll = new XmlCsvTxtBll();

        protected void insertButton_Click(object sender, EventArgs e)
        {

            DataTable table = new DataTable();

            table.Columns.Add();
            table.Columns.Add();
            table.Columns.Add();
            string line;
            using (StreamReader sr = new StreamReader(Server.MapPath("~/GeneratedFiles/CustomerFileTidle.txt")))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split('~');
                    var row = table.NewRow();
                    for (int i = 0; i < parts.Length; i++)
                    {
                        row[i] = parts[i];
                    }
                    // important thing!
                    table.Rows.Add(row);
                }
                sr.Close();
            }

            int count = aXmlCsvTxtBll.CsvAndTxtFileDataInsert(table);
            messageLabel.Text = count + " data inserted successfully";
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}