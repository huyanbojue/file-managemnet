using System;
using System.Data;
using System.IO;
using System.Web.UI.WebControls;

namespace FileManagement.Ui
{
    public partial class Lesson02BXmlFileReadAndBindItToGridViewByUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {

                    if (FileUpload1.PostedFile.FileName == "ProductsFileXml.xml")
                    {
                        FileUpload fu = FileUpload1;
                        StreamReader reader = new StreamReader(fu.FileContent);
                        DataSet theDataSet = new DataSet();
                        theDataSet.ReadXml(reader);

                        productGridView.DataSource = theDataSet.Tables[0];
                        productGridView.DataBind();
                    }
                    else msgLabel.Text = "Upload status: Please Upload ProductsFile.xml ";
                }
                else msgLabel.Text = "Upload status: You Have not uploaded any file ";
            }
            catch (Exception ex)
            {
                 msgLabel.Text = "Upload status: "+ex;
            }
      }
               
        protected void OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //productGridView.PageIndex = e.NewPageIndex;
            //this.BindGrid();
        }
        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}