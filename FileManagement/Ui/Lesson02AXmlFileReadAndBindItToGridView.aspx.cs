using System;
using System.Data;
using System.Web.UI.WebControls;

namespace FileManagement.Ui
{
    public partial class Lesson02AXmlFileReadAndBindItToGridView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!this.IsPostBack)
            //{
            //    this.BindGrid();
            //}
        }

        private void BindGrid()
        {
            using (DataSet ds = new DataSet())
            {
                //ds.ReadXml(Server.MapPath("~/ProductsFileXml.xml"));
                ds.ReadXml(Server.MapPath("~/GeneratedFiles/ProductsFileXml.xml"));
                productGridView.DataSource = ds;
                productGridView.DataBind();
            }
        }

        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            productGridView.PageIndex = e.NewPageIndex;
            this.BindGrid();
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