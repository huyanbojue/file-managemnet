using System;
using System.IO;
using System.Web.UI.WebControls;
using FileManagement.BLL;

namespace FileManagement.Ui
{
    public partial class Lesson03CXmlFileDataInsertIntoSqlDatabseUsingSp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        XmlCsvTxtBll aXmlCsvTxtBll = new XmlCsvTxtBll();
        protected void UploadXML(object sender, EventArgs e)
        {
             if (FileUpload1.HasFile)
                {
                    if (FileUpload1.PostedFile.FileName == "CustomerFileXml.xml")
                    {
                        FileUpload fu = FileUpload1;
                        StreamReader reader = new StreamReader(fu.FileContent);
                        string xml = reader.ReadToEnd();
                        //try
                        //{
                            int count = aXmlCsvTxtBll.InsertXmlFileUsingSp(xml);
                            lblMessage.Text =count+ " data inserted successfully";
                        //}
                        //catch (Exception ex)
                        //{
                        //    lblMessage.Text = "Upload status: " + ex;
                        //}    
                    }  
               else lblMessage.Text = "Upload status: Please Upload CustomerFileXml.xml ";
             }
             else lblMessage.Text = "Upload status: You Have not uploaded any file ";
            }
           

        protected void button_submit_Click(object sender, EventArgs e)
        {
            FileUpload fu = FileUpload1;
            if (fu.HasFile)
            {
                StreamReader reader = new StreamReader(fu.FileContent);
                do
                {
                    string aLine = reader.ReadLine();
                    nameListBox.Items.Add(aLine);
                    // do your coding 
                    //Loop trough txt file and add lines to ListBox1  
                }
                while (reader.Peek() != -1);
                reader.Close();
            }
        }

        protected void backButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Ui/HomeUi.aspx");

        }
    }
}