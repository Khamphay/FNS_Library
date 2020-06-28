using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ProjectLibrary
{
    class MyConnected
    {
        static SqlConnection con = new SqlConnection();
        public static SqlConnection getConnect()
        {
            string strpath = @"Data Source=DELL-INSPIRON-1\SQLEXPRESS;Initial Catalog=db_Libary;Persist Security Info=True; User ID=Khamphay;Password=1234;";
            try
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                con.ConnectionString = strpath;
                con.Open();
                return con;
            }catch(Exception ex)
            {
                return null;
            }
        }
    }
}
