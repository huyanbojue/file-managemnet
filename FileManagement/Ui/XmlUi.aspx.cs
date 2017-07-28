using System;

namespace FileManagement.Ui
{
    public partial class XmlUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

       protected void xmlFileGenerateButton_Click(object sender, EventArgs e)
       {
          Response.Redirect("~/Ui/Lesson01XMLFileGenerateFromSqlDatabase .aspx"); 
       }

      protected void xmlFileViewButton_Click(object sender, EventArgs e)
      {
          Response.Redirect("~/Ui/Lesson02AXmlFileReadAndBindItToGridView.aspx");
      }

      protected void xmlFileViewByUploadButton_Click(object sender, EventArgs e)
      {
         Response.Redirect("~/Ui/Lesson02BXmlFileReadAndBindItToGridViewByUpload.aspx");
      }

      protected void dataInsertButton_Click(object sender, EventArgs e)
      {
          Response.Redirect("~/Ui/Lesson03AXmlFileDataInsertIntoSqlDatabse.aspx");
      }

      protected void dataInsertByUploadButton_Click(object sender, EventArgs e)
      {
          Response.Redirect("~/Ui/Lesson03BXmlFileDataInsertIntoSqlDatabseByUpload.aspx"); 
      }

      protected void dataInsertByUploadUsingSpButton_Click(object sender, EventArgs e)
      {
          Response.Redirect("~/Ui/Lesson03CXmlFileDataInsertIntoSqlDatabseUsingSP.aspx"); 
      }

      protected void backButton_Click(object sender, EventArgs e)
      {
          Response.Redirect("~/Ui/HomeUi.aspx"); 
     
      }
    }
}