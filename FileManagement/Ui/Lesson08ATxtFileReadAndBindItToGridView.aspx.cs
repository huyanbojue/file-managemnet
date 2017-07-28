using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;

namespace FileManagement.Ui
{
    public partial class Lesson08ATxtFileReadAndBindItToGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private void BindGrid()
        {
            DataTable table = new DataTable();

            table.Columns.Add("Product Code");
            table.Columns.Add("Product Name");
            table.Columns.Add("Product Quantity");
            string line;

            using (StreamReader sr = new StreamReader(Server.MapPath("~/GeneratedFiles/ProductsFileTidle.txt")))
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
            GridView1.DataSource = table;
            GridView1.DataBind();
        }
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //productGridView.PageIndex = e.NewPageIndex;
            //this.BindGrid();
        }
        protected void showButton_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}