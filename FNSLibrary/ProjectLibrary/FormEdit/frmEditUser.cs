﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjectLibrary.MSDialog;

namespace ProjectLibrary
{
    public partial class frmEditUser : Form
    {
        public frmEditUser()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmEditUser(Form1 home)
        {
            InitializeComponent();
            _home = home;

            txtid.Text = MyModel.staff[0];
            txtfName.Text = MyModel.staff[1];
            txtlname.Text = MyModel.staff[2];
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        DataTable table = new DataTable();

        bool mouse = false;
        int mouX = 0, mouY = 0;

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
                   MyMessageBox .ShowMesage("ບັນທືກສຳເສັດແລ້ວ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear_Data();
                }
            }
            catch(Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save()
        {

            if (txtOldUserName.Text == MyModel.staff[4])
            {
                if (txtOldPass.Text == MyModel.staff[5])
                {
                    Edit_User();
                }
                else
                {
                    MyMessageBox.ShowMesage("ລະຫັດເກົ່າບໍ່ຖຶກຕ້ອງ. ກະລຸນາກວດສອບແລ້ວລອງໃໝ່ແລ້ວອີກຄັ້ງ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MyMessageBox.ShowMesage("ຊື່ຜູ້ໃຊ້ເກົ່າບໍ່ຖຶກຕ້ອງ. ກະລຸນາກວດສອບແລ້ວລອງໃໝ່ແລ້ວອີກຄັ້ງ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            if (txtNewPass.Text == txtRePass.Text)
            {
                Save();
            }
            else
            {
                MessageBox.Show("Password incorrect");
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
        private void txtRePass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }
    }
}