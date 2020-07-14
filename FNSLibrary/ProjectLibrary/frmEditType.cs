using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;

        public  bool edit = false;
        public string tid = "", tname = "";

        private void Maxid()
        {
            try
            {
                cmd = new SqlCommand("Select Max(typeid) maxid From tbType", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["maxid"].ToString()!="")
                {
                    string textid = "", numid = "";

                    string maxid = dr["maxid"].ToString();
                    char[] ch = maxid.ToCharArray();
                    for (int i = 0; i < ch.Length; i++)
                    {
                        if (!char.IsDigit(ch[i]))
                        {
                            textid += ch[i];
                        }
                        else
                        {
                            numid += ch[i];
                        }
                    }

                    int id = int.Parse(maxid.Substring(maxid.Length - numid.Length)) + 1;
                    if (id >= 100)
                    {
                        txtid.Text = textid + id.ToString();
                    }
                    else if (id >= 10 && id < 100)
                    {
                        txtid.Text = textid + "0" + id.ToString();
                    }
                    else
                    {
                        txtid.Text = textid + "00" + id.ToString();
                    }

                }
                else
                {
                    txtid.Text = "";
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                dr.Close();
            }
        }

        private void SaveAndEdit()
        {
            if (edit == false)
            {
                // Return 1 "Complete action" If Return 0 "Don't complete action"
                if (_type.Save(txtid.Text, txtname.Text) == 1)
                {
                    txtid.Clear();
                    txtname.Clear();
                    Maxid();
                }
            }
            else
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
        private void frmEditType_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();

            //Focus Texbox txtname
            txtname.SelectNextControl((Control)sender, true, true, true, true);

            if (edit == true)
            {
                txtid.Text = tid;
                txtname.Text = tname;
                txtid.Enabled = false;
                tid = "";
                tname = "";
            }
            else
            {
                Maxid();
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            SaveAndEdit();
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

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.lao;
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveAndEdit();
            }
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
