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
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmNewUser(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable table = new DataTable();

        AutoCompleteStringCollection autoshow = new AutoCompleteStringCollection();
        private void Load_Staff_Name()
        {
            try
            {
                cmd = new SqlCommand("Select empid, fname From tbStaff", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Show data when you check the Combobox
                    cmbname.Items.Add(dr["fname"].ToString());
                    //Auto Complete when typing on the ComboBox
                    autoshow.Add(dr["empid"].ToString());
                    autoshow.Add(dr["fname"].ToString());
                }
                txtid.AutoCompleteCustomSource = autoshow;
                txtid.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtid.AutoCompleteSource = AutoCompleteSource.CustomSource;

                cmbname.AutoCompleteCustomSource = autoshow;
                cmbname.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbname.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }catch(Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dr.Close();
            }
        }
        private void AddNew_User()
        {
            try
            {
                if (txtNewPass.Text == txtRePass.Text)
                {
                    cmd = new SqlCommand("Insert Into tbUser Values(@id, @user, @pass)", con);
                    cmd.Parameters.AddWithValue("id", txtid.Text);
                    cmd.Parameters.AddWithValue("user", txtusername.Text);
                    cmd.Parameters.AddWithValue("pass", txtNewPass.Text);
                    if(cmd.ExecuteNonQuery() == 1)
                    {
                        MyMessageBox.ShowMesage("ບັນທືກສຳເສັດແລ້ວ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear_Text();
                    }
                    
                }
                else
                {
                    MyMessageBox.ShowMesage("ຊື່ ແລະ ລະຫັດບໍ່ຖຶກຕ້ອງ. ກະລຸນາກວດສອບແລັວລອງໃໝ່ແລ້ວອີກຄັ້ງ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch(Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       private void Clear_Text()
        {
            txtid.Clear();
            cmbname.ResetText();
            txtlname.Clear();
            txtNewPass.Clear();
            txtRePass.Clear();
            txtusername.Clear();
        }
        private void frmUser_Load(object sender, EventArgs e)
        {
            // Load this model use for Switch Language when you focus the textBox 
            MyModel.getSwitchLanguage();

            Load_Staff_Name();
            
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            cmd = new SqlCommand("Select * From tbUser Where empid='" + txtid.Text + "' And user_name='" + txtusername.Text + "' And password='" + txtNewPass.Text + "'",con);
            da = new SqlDataAdapter(cmd);
            table.Clear();
            da.Fill(table);
            if (table.Rows.Count <= 0) {
                AddNew_User();
            }
            else
            {
                MyMessageBox.ShowMesage("ມີບັນຊີຜູ້ໃຊ້ນີ້ແລ້ວ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cmbname_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                table.Clear();
                da = new SqlDataAdapter("Select empid, lname From tbStaff Where fname=N'"+cmbname.Text+"'", con);
                da.Fill(table);
                if (table.Rows.Count >= 0)
                {
                    txtid.Text = table.Rows[0][0].ToString();
                    txtlname.Text = table.Rows[0][1].ToString();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void cbShowPass1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass1.Checked == true)
            {
                txtNewPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtNewPass.UseSystemPasswordChar = true;
            }
        }

        private void cbShowPass2_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPass2.Checked == true)
            {
                txtRePass.UseSystemPasswordChar = false;
            }
            else
            {
                txtRePass.UseSystemPasswordChar = true;
            }
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            Clear_Text();
        }

        private void txtlname_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            try
            {
                cmbname.ResetText();
                cmd = new SqlCommand("Select fname, lname From tbStaff Where empid='"+txtid.Text+"'", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cmbname.SelectedText = dr["fname"].ToString();
                    txtlname.Text = dr["lname"].ToString();
                }
                else
                {
                    cmbname.ResetText();
                    txtlname.Clear();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                dr.Close();
            }
        }

        private void NextControl(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }
    }
}
