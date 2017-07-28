using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using FileManagement.BLL;

namespace FileManagement.Ui
{
    public partial class Lesson03AXmlFileDataInsertIntoSqlDatabse : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
      

        XmlCsvTxtBll aXmlCsvTxtBll=new XmlCsvTxtBll();
        protected void insertButton_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds.ReadXml(Server.MapPath("~/GeneratedFiles/CustomerFileXml.xml"));
            //ds.ReadXml(Server.MapPath("~/CustomerFile.xml"));

            //XmlReader xmlFile;
            //xmlFile = XmlReader.Create("customer.xml", new XmlReaderSettings());
            //ds.ReadXml(xmlFile);

            string msg = aXmlCsvTxtBll.InsertXmlFile(ds);
            messageLabel.Text = msg;
          
        }
        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}