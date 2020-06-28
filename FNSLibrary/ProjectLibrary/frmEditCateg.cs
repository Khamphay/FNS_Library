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
    public partial class frmEditCateg : Form
    {
        frmCategory _cotg;
        public frmEditCateg(frmCategory cotg)
        {
            InitializeComponent();
            _cotg = cotg;
        }

        public bool edit = false;
        public string id = "", name = "";

        private void NextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void frmEditCateg_Load(object sender, EventArgs e)
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

        private void btsave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                _cotg.Save(txtid.Text, txtname.Text);
            }
            else
            {
                _cotg.Edit(txtid.Text, txtname.Text);
                edit = false;
                this.Close();
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            edit = false;
            txtid.Enabled = true;
            id = "";
            name = "";
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            //Switch anothor Language to English Language
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        
    }
}
