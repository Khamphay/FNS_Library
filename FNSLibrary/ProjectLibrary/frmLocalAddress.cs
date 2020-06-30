using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.SQLite;
using ProjectLibrary.MSDialog;

namespace ProjectLibrary
{
    public partial class frmLocalAddress : Form
    {
        public frmLocalAddress()
        {
            InitializeComponent();
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            try
            {
                MyConnected.ServerName = txtServer.Text;
                MyConnected.batabase = txtDB.Text;
                MyConnected.UserID = txtUser.Text;
                MyConnected.Pass = txtPass.Text;

                SqlConnection con = MyConnected.getConnect();

                if (con.State == ConnectionState.Open)
                {
                    SQLiteConnection mysqlitecon = new SQLiteConnection("Data Source=dbServerName.sqlite3;");
                    mysqlitecon.Open();
                    SQLiteCommand cmd = new SQLiteCommand("Insert Into tbServer Values(@server, @db, @user, @pass);", mysqlitecon);
                    cmd.Parameters.AddWithValue("server", txtServer.Text);
                    cmd.Parameters.AddWithValue("db", txtDB.Text);
                    cmd.Parameters.AddWithValue("user", txtUser.Text);
                    cmd.Parameters.AddWithValue("pass", txtPass.Text);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MyMessageBox.ShowMesage("ເຊື່ອມຕໍ່ຖານຂໍ້ມູນສຳເລັດແລ້ວ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Form1 mainhome = new Form1();
                        mainhome.Show();
                        this.Hide();
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເຊື່ອມຕໍ່ຖານຂໍ້ມູນສຳເລັເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbHasUP_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHasUP.Checked == true)
            {
                txtUser.Enabled = true;
                txtPass.Enabled = true;
            }
            else
            {
                txtUser.Enabled = false;
                txtPass.Enabled = false;
            }
        }

        private void Next_Control(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void frmLocalAddress_Load(object sender, EventArgs e)
        {
            txtServer.Focus();
        }

        private void btCacel_Click(object sender, EventArgs e)
        {
            txtServer.Clear();
            txtDB.Clear();
            txtUser.Clear();
            txtPass.Clear();
            cbHasUP.Checked = false;
        }
    }
}
