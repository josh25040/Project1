using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
namespace Project1
{
    public class SQLDataHandler
    {
        private SqlConnection cn;
        private SqlCommand cmd;
        private string cstring = "Server=DESKTOP-91GL7UQ\\josh2\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;";

        public SqlDataReader getDataReader(String sqltext)
        {
            SqlDataReader dr = null;
            try
            {
                cn = new SqlConnection(cstring);
                cmd = new SqlCommand(sqltext, cn);
                cn.Open();
                dr = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch
            {
                cn.Close();
            }
            return dr;
        }//get data reader

        public Object getScalar(String sqltext)
        {
            Object BigO;
            try
            {
                cn = new SqlConnection(cstring);
                cmd = new SqlCommand(sqltext, cn);
                cn.Open();
                BigO = cmd.ExecuteScalar();
            }
            finally
            {
                cn.Close();
            }//finally
            return BigO;
        }
        public void executeSql(String sqltext)
        {
            try
            {
                cn = new SqlConnection(cstring);
                cmd = new SqlCommand(sqltext, cn);
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }//executeSql

        public DataTable getDataTable(String sqlText)
        {
            DataTable dt;
            SqlDataAdapter da;
            try
            {
                dt = new DataTable();
                cn = new SqlConnection(cstring);
                cmd = new SqlCommand(sqlText, cn);
                da = new SqlDataAdapter(cmd);
                da.Fill(dt);
            }
            finally
            {
                cn.Close();
            }
            return dt;
        }
    }
}