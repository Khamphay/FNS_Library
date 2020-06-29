using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

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
                SQLIte_ServerName.Select_ServerName_FromSqliteTable();
                if ((MyConnected.ServerName != null && MyConnected.batabase != null) || (MyConnected.UserID != null || MyConnected.Pass != null))
                {
                    Application.Run(new Form1());
                }
                else
                {
                    Application.Run(new frmLocalAddress());
                }
            }
        }
    }
}
