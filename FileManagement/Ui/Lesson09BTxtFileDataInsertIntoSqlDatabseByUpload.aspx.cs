﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FileManagement.BLL;

namespace FileManagement
{
    public partial class Lesson09BTxtFileDataInsertIntoSqlDatabseByUpload : System.Web.UI.Page
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
                    DataTable table = new DataTable();

                    table.Columns.Add("Row No.");
                    table.Columns.Add("Col No.");
                    table.Columns.Add("Width");
                    string line;

                    if (FileUpload1.PostedFile.FileName == "CustomerFileTidle.txt")
                    {
                        FileUpload fu = FileUpload1;
                        StreamReader reader = new StreamReader(fu.FileContent);

                        while ((line = reader.ReadLine()) != null)
                        {
                            string[] parts = line.Split('~');
                            var row = table.NewRow();
                            for (int i = 0; i < parts.Length; i++)
                            {
                                row[i] = parts[i];
                            }
                            // important thing!
                            table.Rows.Add(row);
                        }
                        reader.Close();

                        int count = aXmlCsvTxtBll.CsvAndTxtFileDataInsert(table);
                        lblMessage.Text = count + " data inserted successfully";
                    }
                    else lblMessage.Text = "Upload status: Please Upload ProductsFile.txt ";
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