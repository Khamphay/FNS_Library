using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibrary
{
    public partial class frmEditStaff : Form
    {
        frmStaff _staff;
        public frmEditStaff(frmStaff staff)
        {
            InitializeComponent();
            _staff = staff;
        }

        string gender = "";
        public string[] data = new string[5];
        public bool edit = false;
        private void btsave_Click(object sender, EventArgs e)
        {
            if (radimal.Checked == true)
            {
                gender = radimal.Text;
            }
            else
            {
                gender = radifiman.Text;
            }
            if (edit == false)
            {
                _staff.Save(txtid.Text, txtname.Text, txtsurename.Text, gender, txttel.Text);
            }
            else
            {
                _staff.Edit(txtid.Text, txtname.Text, txtsurename.Text, gender, txttel.Text);
                edit = false;
                this.Close();
            }
        }

        private void frmEditStaff_Load(object sender, EventArgs e)
        {
            //Load Model for Switch Language
            MyModel.getSwitchLanguage();
            //
            if (edit == true)
            {
                txtid.Enabled = false;
                txtid.Text = data[0];
                txtname.Text = data[1];
                txtsurename.Text = data[2];
                if (data[3] == "ຊາຍ")
                {
                    radimal.Checked = true;
                }
                else
                {
                    radifiman.Checked = true;
                }
                txttel.Text = data[4];
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
           for(int i=0; i < data.Length; i++)
            {
                data[i] = "";
            }
            txtid.Clear();
            txtname.Clear();
            txtsurename.Clear();
            txttel.Clear();
            radimal.Checked = true;
            txtid.Enabled = true;
            gender = "";
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }

        private void KeyLetter(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void NextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }
    }
}
