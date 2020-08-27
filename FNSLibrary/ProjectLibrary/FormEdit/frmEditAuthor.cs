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
    public partial class frmEditAuthor : Form
    {
        frmAuthor _author;
        public frmEditAuthor(frmAuthor author)
        {
            InitializeComponent();
            _author = author;
        }

        bool mouse = false;
        int mouX = 0, mouY = 0;

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;

        public bool edit = false;
        public string[] data = new string[4];

        private void Maxid()
        {
            try
            {
                cmd = new SqlCommand("Select Max(athid) maxid From tbAthor", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
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
            if (txtid.Text != "" && txtlname.Text != "" && txtfname.Text != "" && txttel.Text!="")
            {
                if (edit == false)
                {
                    // if return 1 "Complete" else if 0 "Don't complete"
                    if (_author.Save(txtid.Text, txtfname.Text, txtlname.Text, txttel.Text) == 1)
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
            else
            {
                MyMessageBox.ShowMesage("ກະລຸນາກວດສອບຂໍ້ມູນ ແລ້ວລອງໃຫມ່ອີກຄັ້ງ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
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
            Maxid();
        }

        private void frmEditAuthor_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            //Focus Texbox txtname
            txtfname.SelectNextControl((Control)sender, true, true, true, true);

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
            SaveAndEdit();
        }

        private void txttel_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txttel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveAndEdit();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
