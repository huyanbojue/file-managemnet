using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Web.UI.WebControls;
using FileManagement.BLL;

namespace FileManagement.Ui
{
    public partial class Lesson03BXmlFileDataInsertIntoSqlDatabseByUpload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        XmlCsvTxtBll aXmlCsvTxtBll = new XmlCsvTxtBll();
       
        protected void UploadXML(object sender, EventArgs e)
        {
            try
            {
                if (FileUpload1.HasFile)
                {
                    if (FileUpload1.PostedFile.FileName == "CustomerFileXml.xml")
                    {
                        FileUpload fu = FileUpload1;
                        StreamReader reader = new StreamReader(fu.FileContent);
                        DataSet ds = new DataSet();
                        ds.ReadXml(reader);

                        string msg = aXmlCsvTxtBll.InsertXmlFile(ds);
                        lblMessage.Text = msg;
                    }

                    else lblMessage.Text = "Upload status: Please Upload EmployeeFile.xml ";
                }
                else lblMessage.Text = "Upload status: You Have not uploaded any file ";
            }
            catch (Exception ex)
            {
                lblMessage.Text = "Upload status: " + ex;
            }

        }
        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}