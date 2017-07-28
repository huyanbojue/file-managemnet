using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;

namespace FileManagement.Ui
{
    public partial class Lesson08BTxtFileReadAndBindItToGridViewByUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    DataTable table = new DataTable();

                    table.Columns.Add("Product Code");
                    table.Columns.Add("Product Name");
                    table.Columns.Add("Product Quantity");
                    string line;

                    if (FileUpload1.PostedFile.FileName == "ProductsFileTidle.txt")
                    {
                        FileUpload fu = FileUpload1;
                        StreamReader reader = new StreamReader(fu.FileContent);

                        while ((line = reader.ReadLine()) != null)
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
                        reader.Close();
                        GridView1.DataSource = table;
                        GridView1.DataBind();

                    }
                    else msgLabel.Text = "Upload status: Please Upload ProductsFile.txt ";
                }
                else msgLabel.Text = "Upload status: You Have not uploaded any file ";
            }
            catch (Exception ex)
            {
                msgLabel.Text = "Upload status: " + ex;
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}