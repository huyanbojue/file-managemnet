using System;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using FileManagement.BLL;

namespace FileManagement.Ui
{
    public partial class Lesson01XmlFileGenerateFromSqlDatabase: System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        XmlCsvTxtBll aXmlCsvTxtBll = new XmlCsvTxtBll();
        protected void saveButton_Click(object sender, EventArgs e)
         {
            try
            {
               
                DataSet DS = new DataSet();
                DS = aXmlCsvTxtBll.XmlFileGenerate();

                String fileName = "ProductsFileXml.xml";
                String filePath = Server.MapPath("~\\GeneratedFiles\\") + fileName;
                DS.WriteXml(filePath);

                //........Rules1................................//
                //string aXmlFile = Server.MapPath("ProductsFileXml.xml");
                //DS.WriteXml(aXmlFile);

                //........Rules2................................//
                //DS.ReadXml(Request.PhysicalApplicationPath + "ProductsFileXml.xml");
                //aXmlFile.Equals(DS);

                //........Rules3................................//
                //XmlDataDocument xmlDoc = new XmlDataDocument(DS);
                //xmlDoc.Save(Server.MapPath("~/ProductsFileXml.xml"));
                
                //........Rules4................................//
                //DS.WriteXmlSchema(Server.MapPath("ProductsFileXml.xml"));
                //DS.WriteXml(Server.MapPath("ProductsFileXml.xml"));

               //  messageLabel.Text = "XML File Generated Successfully";
                xmlLabel.Text = "<a a href=../GeneratedFiles/ProductsFileXml.xmll> View XML file</a>";
              
            }
            catch (Exception ex)
            {
                messageLabel.Text = "Error" + ex;
            }

         }

        protected void xmlLinkButton_Click(object sender, EventArgs e)
        {
            xmlLabel.Text = "<a href=../GeneratedFiles/ProductsFileXml.xml> View XML file</a>";
            //xmlLabel.Text = "<a href=Employee.xml> View XML file</a>";
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}