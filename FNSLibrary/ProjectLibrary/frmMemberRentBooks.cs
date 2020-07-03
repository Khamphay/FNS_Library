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

namespace ProjectLibrary
{
    public partial class frmMemberRentBooks : Form
    {
        Form1 _home;
        public frmMemberRentBooks(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;
        AutoCompleteStringCollection auto;
        DateTime ExpireMember;
        private void LoadMemberID()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select mid From tbMember", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.Add(dr["mid"].ToString());
                }
                txtmemberid.AutoCompleteCustomSource = auto;
                txtmemberid.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtmemberid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load member id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void OpenRentBooks()
        {
            if (txtmemberid.Text != "" && txtfname.Text != "" && txtlname.Text != "" && txtTel.Text != "")
            {
               // frmRentBook.memberid = txtmemberid.Text;
                //_home.OpenRentBooksForm();
                //this.Close();
            }
            else
            {
                MessageBox.Show("Please check the member information and try again", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                
        }
        private void FillData_ToTextBox()
        {
            try
            {
                cmd = new SqlCommand("Select fname, lname, tel, dateREd From tbMember Where mid='" + txtmemberid.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    txtfname.Text = dr["fname"].ToString();
                    txtlname.Text = dr["lname"].ToString();
                    txtTel.Text = dr["tel"].ToString();
                    ExpireMember = DateTime.Parse(dr["dateREd"].ToString());
                }
                else
                {
                    txtfname.Clear();
                    txtlname.Clear();
                    txtTel.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void Check_MemberRent()
        {
            try
            {
                cmd = new SqlCommand("Select mbid From tbRent_Detail Where status=N'ກຳລັງຢືມ' AND mbid='" + txtmemberid.Text + "'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["mbid"].ToString() == txtmemberid.Text)
                {
                    MessageBox.Show("This member is rented!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btsave.Enabled = false;
                }
                {
                    btsave.Enabled = true;
                    OpenRentBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Check data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

        private void frmMemberRentBooks_Load(object sender, EventArgs e)
        {
            LoadMemberID();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            OpenRentBooks();
        }

        private void txtmemberid_TextChanged(object sender, EventArgs e)
        {
            FillData_ToTextBox();
            if (txtmemberid.Text != "" && txtfname.Text != "" && txtlname.Text != "" && txtTel.Text != "")
            {
                if (ExpireMember.CompareTo(DateTime.Now) == 1)
                {
                    //Check Data
                    Check_MemberRent();
                }
                else
                {
                    MessageBox.Show("This card is expire", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btsave.Enabled = false;
                }
            }
        }

        private void Control_NotType(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
