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
    public partial class frmEditType : Form
    {
        frmType _type;
        public frmEditType(frmType type)
        {
            InitializeComponent();
            _type = type;
        }

        public  bool edit = false;
        public string tid = "", tname = "";

        private void frmEditType_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            if (edit == true)
            {
                txtid.Text = tid;
                txtname.Text = tname;
                txtid.Enabled = false;
                tid = "";
                tname = "";
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (edit == false)
            {
                // Return 1 "Complete action" If Return 0 "Don't complete action"
                if(_type.Save(txtid.Text, txtname.Text) == 1)
                {
                    txtid.Clear();
                    txtname.Clear();
                }
            }else
            {
                // Return 1 "Complete action" If Return 0 "Don't complete action"
                if (_type.Edit(txtid.Text, txtname.Text) == 1)
                {
                    edit = false;
                    this.Close();
                    txtid.Clear();
                    txtname.Clear();
                }                
            }
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtname.Clear();
            tid = "";
            tname = "";
            txtid.Enabled = true;
            edit = false;
        }

        private void txtid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
    }
}
