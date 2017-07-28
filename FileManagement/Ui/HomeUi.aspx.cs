using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace FileManagement.Ui
{
    public partial class HomeUi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bookinfoButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/XmlUi.aspx");
        }

        protected void csvButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/csvUi.aspx");
        }

        protected void txtButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/txtUi.aspx");
        }

      
    }
}