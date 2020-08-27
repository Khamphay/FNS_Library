using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ProjectLibrary.MSDialog;

namespace ProjectLibrary
{
    public partial class frmEditTable : Form
    {
        frmTable _fmtable;
        public frmEditTable(frmTable fmtable)
        {
            InitializeComponent();
            _fmtable = fmtable;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable table;
        public bool edit = false;
        public string id1 = "", id2 = "";
        int subid = 0;
        string maxid = "";

        bool mouse = false;
        int mouX = 0, mouY = 0;

        private void SaveAndEdit()
        {
            if (txtid.Text != "" && txtQty.Text != "" && txtidd.Text != "")
            {

                if (edit == false)
                {
                    // Return 1 "Complete action" If Return 0 "Don't complete action"
                    if (_fmtable.Save(txtid.Text, int.Parse(txtQty.Text)) == 1)
                    {
                        txtid.Clear();
                        txtidd.Clear();
                        txtQty.Clear();
                    }
                }
                else
                {
                    // Return 1 "Complete action" If Return 0 "Don't complete action"
                    if (_fmtable.Edit(txtidd.Text) == 1)
                    {
                        edit = false;
                        this.Close();
                        txtid.Clear();
                        txtidd.Clear();
                        txtQty.Clear();
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
            txtid.Clear();
            txtidd.Clear();
            txtQty.Clear();
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
            txtidd.Clear();
            if (txtQty.Text != "")
            {
                if (int.Parse(txtQty.Text) > 0 && int.Parse(txtQty.Text)<=20)
                {
                    table = new DataTable();
                    table.Clear();
                    da = new SqlDataAdapter("select Max(tbdid) from tbTable Where tbid='" + txtid.Text + "'", con);
                    da.Fill(table);
                    if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
                    {
                        maxid = table.Rows[0][0].ToString();
                        char[] m= maxid.ToCharArray();
                        int a = 1;
                        for(int c=0; c < m.Length; c++)
                        {
                            if (char.IsLetter(m[c]))
                            {
                                a += 1;
                            }
                        }
                        subid = int.Parse(maxid.Substring(a));
                    }

                    if (txtid.Text == "")
                    {
                        txtidd.Text = "";
                        txtQty.Text = "";
                    }
                    else
                    {
                        if (subid >= 1)
                        {
                            for (int i = 1; i <= int.Parse(txtQty.Text); i++)
                            {
                                subid += 1;
                                if (subid < 10)
                                {
                                    txtidd.Text += $"{txtid.Text}00{subid}\n";
                                }
                                else if (subid >= 10 && subid < 100)
                                {
                                    txtidd.Text += $"{txtid.Text}0{subid} \n";
                                }
                                else
                                {
                                    txtidd.Text = $"{txtid.Text}{subid}";
                                }
                            }
                            subid = 0;
                        }
                        else
                        {
                            for (int j = 1; j <= int.Parse(txtQty.Text); j++)
                            {
                                if (j < 10)
                                {
                                    txtidd.Text += $"{txtid.Text}00{j}\n";
                                }
                                else if (j >= 10 && j < 100)
                                {
                                    txtidd.Text += $"{txtid.Text}0{j}\n";
                                }
                                else
                                {
                                    txtidd.Text += $"{txtid.Text}{j}\n";
                                }
                            }
                        }
                        // txtQty.Text = "1";
                    }
                }
                else
                {
                    txtQty.Text = "1";
                }
            }
            else
            {
                txtidd.Clear();
            }
        }
        
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }

        private void NextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtQty_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            SaveAndEdit();
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtid.Clear();
            txtidd.Clear();
            txtQty.Clear();
            edit = false;
            txtid.Enabled = true;
            txtQty.Enabled = true;
        }

        private void txtQty_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void txtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveAndEdit();
                txtid.Focus();
            }
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Text != "")
            {
                txtQty.Text = "1";
            }
            else
            {
                txtQty.Clear();
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }

        private void frmEditTable_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            if (edit == true)
            {
                txtid.Text = id1;
                txtid.Enabled = false;
                txtQty.Enabled = false;
                txtQty.Text = "1";
                txtidd.Text = id2;
            }
        }
    }
}
