using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using FileManagement.Gateway;

namespace FileManagement.BLL
{
    public class XmlCsvTxtBll
    {

        private XmlCsvTxtGateway aXmlCsvTxtGateway = new XmlCsvTxtGateway();

        public DataSet XmlFileGenerate()
        {
            DataSet da = aXmlCsvTxtGateway.XmlFileGenerate();
            return da;
        }
        public String InsertXmlFile(DataSet ds)
        {
            int count = aXmlCsvTxtGateway.InsertXmlFile(ds);
            if (count == 0)
                return "Data insertion failed or no data in File";
            else return count + " Data inserted Successfully";
        }

        public int InsertXmlFileUsingSp(string xml)
        {
            int count = aXmlCsvTxtGateway.InsertXmlFileUsingSp(xml);
            return count;
        }

        public DataTable CsvAndTxtFileGenerate()
        {
            DataTable dt = aXmlCsvTxtGateway.CsvAndTxtFileGenerate();
            return dt;
        }

        public int CsvAndTxtFileDataInsert(DataTable table)
        {
           int count = aXmlCsvTxtGateway.CsvAndTxtFileDataInsert(table);
           return count;

        }
    }
}