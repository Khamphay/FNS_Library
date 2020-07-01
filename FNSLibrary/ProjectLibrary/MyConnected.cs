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

        public static string ServerName, batabase, UserID, Pass;

        static SqlConnection con = new SqlConnection();
        public static SqlConnection getConnect()
        {
            string strpath = @"Data Source="+ ServerName + ";Initial Catalog="+ batabase + ";Integrated Security=True; User ID="+ UserID + ";Password="+ Pass+ ";";
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
