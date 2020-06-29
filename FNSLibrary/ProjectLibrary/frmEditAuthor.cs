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
    public partial class frmEditAuthor : Form
    {
        frmAuthor _author;
        public frmEditAuthor(frmAuthor author)
        {
            InitializeComponent();
            _author = author;
        }

        public bool edit = false;
        public string[] data = new string[4];
        private void Clear_Data()
        {
            txtid.Clear();
            txtfname.Clear();
            txtlname.Clear();
            txttel.Clear();
            txtid.Enabled = true;
            edit = false;
            for(int i = 0; i < data.Length; i++)
            {
                data[i] = "";
            }
        }
        private void frmEditAuthor_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            if (edit == true)
            {
                txtid.Text = data[0];
                txtfname.Text = data[1];
                txtlname.Text = data[2];
                txttel.Text = data[3];
                txtid.Enabled = false;

            }
        }

        private void KeyLetter(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }

        private void NextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear_Data();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                // if return 1 "Complete" else if 0 "Don't complete"
                if ( _author.Save(txtid.Text, txtfname.Text, txtlname.Text, txttel.Text) == 1)
                {
                    Clear_Data();
                }
            }
            else
            {
                // if return 1 "Complete" else if 0 "Don't complete"
                if (_author.Edit(txtid.Text, txtfname.Text, txtlname.Text, txttel.Text) == 1)
                {
                    edit = false;
                    Clear_Data();
                    this.Close();
                }
            }
        }
    }
}
