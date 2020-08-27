using BarcodeStandard;
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
    public partial class frmEditStaff : Form
    {
        frmStaff _staff;
        public frmEditStaff(frmStaff staff)
        {
            InitializeComponent();
            _staff = staff;
        }


        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;

        bool mouse = false;
        int mouX = 0, mouY = 0;

        string gender = "";
        public string[] data = new string[5];
        public bool edit = false;

        private void Maxid()
        {
            try
            {
                cmd = new SqlCommand("Select Max(empid) maxid From tbStaff", con);
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
            if (txtid.Text!="" && txtname.Text!="" && txtsurename.Text!="" && txttel.Text!="")
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
                    // Return 1 "Complete action" If Return 0 "Don't complete action"
                    if (_staff.Save(txtid.Text, txtname.Text, txtsurename.Text, gender, txttel.Text) == 1)
                    {
                        ClearData();
                    }
                }
                else
                {
                    // Return 1 "Complete action" If Return 0 "Don't complete action"
                    if (_staff.Edit(txtid.Text, txtname.Text, txtsurename.Text, gender, txttel.Text) == 1)
                    {
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
        private void ClearData()
        {
            for (int i = 0; i < data.Length; i++)
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
            Maxid();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            SaveAndEdit();
        }

        private void frmEditStaff_Load(object sender, EventArgs e)
        {
            //Load Model for Switch Language
            MyModel.getSwitchLanguage();
            //Focus Texbox txtname
            txtname.SelectNextControl((Control)sender, true, true, true, true);

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
            else
            {
                Maxid();
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearData();
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


        private void txttel_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveAndEdit();
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
                this.SetDesktopLocation(MousePosition.Y - mouX, MousePosition.Y - mouY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
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
    }
}
