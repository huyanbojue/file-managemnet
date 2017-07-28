using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileManagement.Ui
{
    public partial class CsvUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void csvFileGenerateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson04CsvFileGenerateFromSqlDatabase.aspx"); 
        }

        protected void csvFileViewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson05ACsvFileReadAndBindItToGridView.aspx"); 
        }

        protected void csvFileViewByUploadButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson05BCsvFileReadAndBindItToGridViewByUpload.aspx"); 
        }
        protected void dataInsertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson06ACsvFileDataInsertIntoSqlDatabse.aspx"); 
        }

        protected void dataInsertByUploadButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson06BCsvFileDataInsertIntoSqlDatabseByUpload.aspx"); 
        }

    
        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx"); 
        }

        
    }
}