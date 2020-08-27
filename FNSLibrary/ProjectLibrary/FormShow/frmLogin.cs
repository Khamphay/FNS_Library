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
using ProjectLibrary.MSDialog;

namespace ProjectLibrary
{
    public partial class frmLogin : Form
    {
        Form1 _home;
        public frmLogin(Form1 home)
        {
            InitializeComponent();
            _home = home;
            //panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;

        // For move form
        bool mouse=false;
        int mouseX = 0, mouseY = 0;

        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະອອກຈາກຟອມເຂົ້າສູ່ລະບົບບໍ່?", "Closing Programe", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void gunaAdvenceButton8_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btCancle_Click(object sender, EventArgs e)
        {
            txtUser.Clear();
            txtPass.Clear();
        }

        private void cbShowPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar == true)
            {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }
           
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.ActiveControl = txtUser;
        }

        private void txtUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPass.Focus();
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btSingin.Focus();
               _home.Login(txtUser.Text,txtPass.Text, this);
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void btSingin_Click(object sender, EventArgs e)
        {
            _home.Login(txtUser.Text, txtPass.Text, this);
        }
    }
}
