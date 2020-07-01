using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibrary
{
    public partial class HomePage : UserControl
    {
        Form1 _home;
        public HomePage(Form1 home)
        {
            InitializeComponent();
            _home = home;

            if (MyModel.staff[0] == null && MyModel.staff[1] == null && MyModel.staff[2] == null)
            {
                btLogin.Text = "Log In";
            }
            else
            {
                btLogin.Text = "Log Out";
            }
        }

        private void gunaLinePanel1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MyModel.staff[0]==null && MyModel.staff[1]==null && MyModel.staff[2] == null)
            {
                frmLogin login = new frmLogin(_home);
                login.ShowDialog();
            }
            else
            {
                _home.LogOut();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmReserve reserve = new frmReserve(_home);
            _home.ShowSubForm(reserve);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(_home);
            _home.ShowSubForm(search);
        }

        private void btReservertion_MouseLeave(object sender, EventArgs e)
        {
            MyModel.MouseLeave(Properties.Resources.reserve_90px, Color.Transparent, Color.Black, btReservertion);
        }

        private void btReservertion_MouseHover(object sender, EventArgs e)
        {
            MyModel.MouseLeave(Properties.Resources.reserve_90px1, Color.Transparent, Color.WhiteSmoke, btReservertion);
        }

        private void btSearch_MouseHover(object sender, EventArgs e)
        {
            MyModel.MouseLeave(Properties.Resources.search_90px2, Color.Transparent, Color.WhiteSmoke, btSearch);
        }

        private void btSearch_MouseLeave(object sender, EventArgs e)
        {
            MyModel.MouseLeave(Properties.Resources.search_90px, Color.Transparent, Color.Black, btSearch);
        }

        private void btLogin_MouseHover(object sender, EventArgs e)
        {
            MyModel.MouseLeave(Properties.Resources.Login2, Color.Transparent, Color.WhiteSmoke, btLogin);
        }

        private void btLogin_MouseLeave(object sender, EventArgs e)
        {
            MyModel.MouseLeave(Properties.Resources.Login1, Color.Transparent, Color.Black, btLogin);
        }
    }
}
