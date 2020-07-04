using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using System.Data.SqlClient;
using System.Data;

namespace ProjectLibrary
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Check the server sattus before Open Program
            if (!File.Exists("./dbServerName.sqlite3"))
            {
                SQLIte_ServerName.CreateNewDatabase();

                //Create new server name
                Application.Run(new frmLocalAddress());
            }
            else
            {
                //Select Sername, database, UserID and Passsword And Set to connection 'MyConnect'
                SQLIte_ServerName.Select_ServerName_FromSqliteTable();

                //Check connect to database
                SqlConnection con = MyConnected.getConnect();
                if (con!=null)
                {
                    Application.Run(new Form1());
                }
                else
                {
                    //Delete ServerName From SQLite database
                    SQLiteConnection sqlitecon = SQLIte_ServerName.mysqlitecon;
                    sqlitecon.Open();
                    SQLIte_ServerName.cmd = new SQLiteCommand("Delete From tbServer",sqlitecon);
                    SQLIte_ServerName.cmd.ExecuteNonQuery();

                    Application.Run(new frmLocalAddress());
                }
            }
        }
    }
}
