using ProjectLibrary.MSDialog;
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
    public partial class frmEditCateg : Form
    {
        frmCategory _cotg;
        public frmEditCateg(frmCategory cotg)
        {
            InitializeComponent();
            _cotg = cotg;
        }

        bool mouse=false;
        int mouX = 0, mouY = 0;

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;

        public bool edit = false;
        public string id = "", name = "";
        private void Maxid()
        {
            try
            {
                cmd = new SqlCommand("Select Max(catgid) maxid From tbCategory", con);
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
            if (txtid.Text != "" && txtname.Text != "")
            {
                if (edit == false)
                {
                    // if return 1 "Complete" else if 0 "Don't complete"
                    if (_cotg.Save(txtid.Text, txtname.Text) == 1)
                    {
                        txtid.Clear();
                        txtname.Clear();
                        Maxid();
                    }
                }
                else
                {
                    // if return 1 "Complete" else if 0 "Don't complete"
                    if (_cotg.Edit(txtid.Text, txtname.Text) == 1)
                    {
                        txtid.Clear();
                        txtname.Clear();
                        edit = false;
                        this.Close();
                    }
                }
            }
            else
            {
                MyMessageBox.ShowMesage("ກະລຸນາກວດສອບຂໍ້ມູນ ແລ້ວລອງໃຫມ່ອີກຄັ້ງ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
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
            //Focus Texbox txtname
            txtname.SelectNextControl((Control)sender, true, true, true, true);

            if (edit == true)
            {
                txtid.Text = id;
                txtname.Text = name;
                txtid.Enabled = false;
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
            edit = false;
            txtid.Enabled = true;
            id = "";
            name = "";
            Maxid();
        }

        private void txtname_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveAndEdit();
            }
        }

        private void txtname_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.lao;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMinimam_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }
        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            //Switch anothor Language to English Language
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        
    }
}
