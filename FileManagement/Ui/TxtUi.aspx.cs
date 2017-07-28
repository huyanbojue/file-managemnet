using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileManagement.Ui
{
    public partial class TxtUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtFileGenerateButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson07TxtFileGenerateFromSqlDatabase.aspx"); 
        }

        protected void txtFileViewButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson08ATxtFileReadAndBindItToGridView.aspx"); 
        }

        protected void txtFileViewByUploadButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson08BTxtFileReadAndBindItToGridViewByUpload.aspx"); 
        }

        protected void dataInsertButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson09ATxtFileDataInsertIntoSqlDatabse.aspx"); 
        }

        protected void dataInsertByUploadButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/Lesson09BTxtFileDataInsertIntoSqlDatabseByUpload.aspx"); 
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx"); 
        }
    }
}