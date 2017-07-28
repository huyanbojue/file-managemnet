using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;

namespace FileManagement.Gateway
{
    public class XmlCsvTxtGateway
    {

    SqlConnection aConnection = new SqlConnection();
    public XmlCsvTxtGateway()
    {
        string connectionString = ConfigurationManager.ConnectionStrings["XmlTxtCsvDBConnectionString"].ConnectionString;
        aConnection.ConnectionString = connectionString;
    }

    public DataSet XmlFileGenerate()
    {
        aConnection.Open();
        //string selectString = string.Format("DELETE FROM Book");
        //SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(selectString, aConnection);
        //DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("select ProductCode,ProductName,ProductQuantity from Product ", aConnection);
        DataSet dt = new DataSet("AllProducts");
        da.Fill(dt,"aProduct");
        aConnection.Close();
        return dt;
    }
    public int InsertXmlFile(DataSet ds)
    {
        aConnection.Open();
        string sql = null;
        SqlCommand command;
        SqlDataAdapter adpter = new SqlDataAdapter();

        int count = 0;
        int CustomerId;
        string CustomerName;
        string CustomerAddress;
 
        for (int i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
        {
            CustomerId = Convert.ToInt32(ds.Tables[0].Rows[i].ItemArray[0]);
            CustomerName = ds.Tables[0].Rows[i].ItemArray[1].ToString();
            CustomerAddress = ds.Tables[0].Rows[i].ItemArray[2].ToString();
            //sql = "insert into Customer values(" + CustomerId + ",'" + CustomerName + "','" + CustomerAddress + "')";

            sql = string.Format("INSERT INTO Customer VALUES({0},'{1}','{2}')", CustomerId, CustomerName, CustomerAddress);
            command = new SqlCommand(sql, aConnection);
            adpter.InsertCommand = command;
            adpter.InsertCommand.ExecuteNonQuery();
            count++;
        }
        aConnection.Close();
        return count;
       
    }

    public int InsertXmlFileUsingSp(string xml)
    {
        int count = 0;
        SqlCommand cmd = new SqlCommand("InsertCustomerXML", aConnection);
        cmd.CommandType = CommandType.StoredProcedure;

        cmd.Parameters.AddWithValue("@XMLdata", xml);
        cmd.Parameters.Add("@count", SqlDbType.Int);
        cmd.Parameters["@count"].Direction = ParameterDirection.Output;
        
        aConnection.Open();
        cmd.ExecuteNonQuery();
        count = (int)cmd.Parameters["@count"].Value;
        aConnection.Close();
        return count;

     }

    public DataTable CsvAndTxtFileGenerate()
    {
        aConnection.Open();
        //string selectString = string.Format("DELETE FROM Book");
        //SqlDataAdapter sqlDataAdapterObj = new SqlDataAdapter(selectString, aConnection);
        //DataTable dt = new DataTable();
        SqlDataAdapter da = new SqlDataAdapter("select ProductCode,ProductName,ProductQuantity from Product ", aConnection);
        
        DataTable dt = new DataTable();
        da.Fill(dt);
        aConnection.Close();
        return dt;
    }

    public int CsvAndTxtFileDataInsert(DataTable table)
    {
        aConnection.Open();
        string sql = null;
        SqlCommand command;
        SqlDataAdapter adpter = new SqlDataAdapter();

        int count = 0;
        int CustomerId = 0;
        string CustomerName = null;
        string CustomerAddress = null;


        for (int i = 0; i <= table.Rows.Count - 1; i++)
        {
            CustomerId = Convert.ToInt32(table.Rows[i].ItemArray[0]);
            CustomerName = table.Rows[i].ItemArray[1].ToString();
            CustomerAddress = table.Rows[i].ItemArray[2].ToString();
            //sql = "insert into Customer values(" + CustomerId + ",'" + CustomerName + "','" + CustomerAddress + "')";

            sql = string.Format("INSERT INTO Customer VALUES({0},'{1}','{2}')", CustomerId, CustomerName, CustomerAddress);
            command = new SqlCommand(sql, aConnection);
            adpter.InsertCommand = command;
            adpter.InsertCommand.ExecuteNonQuery();
            count++;
        }
        aConnection.Close();
        return count;
    }
    }
}