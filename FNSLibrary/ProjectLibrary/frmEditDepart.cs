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
    public partial class frmEditDepart : Form
    {
        frmDetpart _depart;
        public bool edit = false;
        public string id = "", name = "";
        public frmEditDepart(frmDetpart depart)
        {
            InitializeComponent();
            _depart = depart;
        }

        private void frmEditDepart_Load(object sender, EventArgs e)
        {
            // Load this Model for Switch Languase when focus on the TextBox
            MyModel.getSwitchLanguage();
            //
            if (edit == true)
            {
                txtid.Text = id;
                txtname.Text = name;
                txtid.Enabled = false;
            }
        }

        private void NextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                _depart.Save(txtid.Text, txtname.Text);
            }
            else
            {
                _depart.Edit(txtid.Text, txtname.Text);
                edit = false;
                this.Close();
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            id = "";
            name = "";
            txtid.Enabled = true;
            edit = false;
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }
    }
}
