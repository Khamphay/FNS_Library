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

namespace ProjectLibrary
{
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();

            txtid.Text = MyModel.staff[0];
            txtfName.Text = MyModel.staff[1];
            txtlname.Text = MyModel.staff[2];
        }

        Form1 _home;
        public frmEditUser(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        DataTable table = new DataTable();
        private void Edit_User()
        {
            try
            {
                cmd = new SqlCommand("Update tbUser Set user_name=@newsuser, password=@pass Where empid=@id And user_name=@olduser And password=@oldpass", con);
                cmd.Parameters.AddWithValue("id", txtid.Text);
                cmd.Parameters.AddWithValue("olduser", txtOldUserName.Text);
                cmd.Parameters.AddWithValue("oldpass", txtOldPass.Text);
                cmd.Parameters.AddWithValue("newsuser", txtNewsUser.Text);
                cmd.Parameters.AddWithValue("pass", txtNewPass.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Save completed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Data();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void Clear_Data()
        {
            txtid.Clear();
            txtfName.Clear();
            txtlname.Clear();
            txtNewPass.Clear();
            txtNewsUser.Clear();
            txtOldPass.Clear();
            txtOldUserName.Clear();
            txtRePass.Clear();
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            frmNewUser newuser = new frmNewUser();
            newuser.ShowDialog();
        }

        private void frmEditUser_Load(object sender, EventArgs e)
        {
            // Load this model use for Switch Language when you focus the textBox 
            MyModel.getSwitchLanguage();
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void cbShowPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass1.Checked == true)
            {
                txtOldPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtOldPass.UseSystemPasswordChar = true;
            }
        }

        private void cbShowPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass2.Checked == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void cbShowPass3_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass3.Checked == true)
            {
                txtRePass.UseSystemPasswordChar = false;
            }
            else
            {
                txtRePass.UseSystemPasswordChar = true;
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtOldUserName.Text==MyModel.staff[4])
            {
                if (txtOldPass.Text == MyModel.staff[5])
                {
                    Edit_User();
                }
                else
                {
                    MessageBox.Show("Your old Password incorrent. Please check and try again!! ", "Edit user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Your Username incorrent. Please check and try again!!", "Edit user", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }
    }
}
