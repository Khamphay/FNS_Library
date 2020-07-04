using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ProjectLibrary
{
    class SQLIte_ServerName
    {
        public static SQLiteConnection mysqlitecon = new SQLiteConnection("Data Source=dbServerName.sqlite3;");
        public static SQLiteCommand cmd;
        public static SQLiteDataReader sdr;


        public static void CreateNewDatabase()
        {
            //Create file dbServerName.sqlite3
            SQLiteConnection.CreateFile("dbServerName.sqlite3");

            //Connect And crate database (First time of Run Program)
            mysqlitecon = new SQLiteConnection("Data Source=dbServerName.sqlite3;");
            mysqlitecon.Open();

            //Create Table
             cmd = new SQLiteCommand("Create table tbServer(SVname varchar(100), UserID Varchar(20), Pass Varchar(20));", mysqlitecon);
            cmd.ExecuteNonQueryAsync();

            mysqlitecon.Close();

        }
        public static void Select_ServerName_FromSqliteTable()
        {
            try
            {
                mysqlitecon.Open();
                cmd = new SQLiteCommand("Select * From tbServer;", mysqlitecon);
                sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    sdr.Read();
                    MyConnected.ServerName = sdr["SVname"].ToString();
                    MyConnected.UserID = sdr["UserID"].ToString();
                    MyConnected.Pass = sdr["Pass"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                sdr.Close();
                mysqlitecon.Close();
            }
           
        }

    }
}
