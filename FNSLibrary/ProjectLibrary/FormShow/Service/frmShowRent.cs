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
using System.Web.UI;
using System.Windows.Forms;

namespace ProjectLibrary.Report
{
    public partial class frmShowRent : Form
    {
        public frmShowRent()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            lbMid.ResetText();
            lbName.ResetText();
            lbTel.ResetText();
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
        DataTable table;
        SqlDataReader dr;

        bool mouse = false;
        int mouX =0, mouY = 0;
       // string[] col = { "ລະຫັດບາໂຄດ", "ຊື່ປຶ້ມ", "ໝວດ", "ປະເພດ", "ຈຳນວນໜ້າ", "ລະຫັດຕູ້", "ຈຳນວນ", "ວັນທີຢືມ" , "ວັນທີສົ່ງ", "ສະຖານະ" };
        string SqlQeury="",sql = "SELECT barcode, bname,  name,typename, page, qty, tbdid, datest, dateed, status  From vw_RentBooks ";
        string month = DateTime.Now.ToString("MM-yyyy");
        int year = DateTime.Now.Year;

       private void ShowData()
        {
            try
            {
                SqlQeury = "";
                if (rdbRenting.Checked == true)
                {
                    if (cbMonth.Checked == true && rdbRenting.Checked == true)
                    {
                        SqlQeury = sql + "  Where status=N'ກຳລັງຢືມ' And Format(datest,'MM-yyyy')='" + month + "'";
                    }
                    else if (cbYear.Checked == true && rdbRenting.Checked == true)
                    {
                        SqlQeury = sql + " Where status=N'ກຳລັງຢືມ' And Year(datest)=" + year;
                    }
                    else
                    {
                        SqlQeury = sql + " Where status=N'ກຳລັງຢືມ'";
                    }
                    
                }
                else if (rdbRented.Checked == true)
                {
                     if (cbMonth.Checked == true && rdbRented.Checked == true)
                    {
                        SqlQeury = sql + " Where status=N'ສົ່ງແລ້ວ' And Format(dateed,'MM-yyyy')='" + month + "'";
                    }
                    else if (cbYear.Checked == true && rdbRented.Checked == true)
                    {
                        SqlQeury = sql + " Where status=N'ສົ່ງແລ້ວ' And Year(dateed)=" + year;
                    }
                    else
                    {
                        SqlQeury = sql + " Where status=N'ສົ່ງແລ້ວ'";
                    }
                    
                }
                else if (rdbRentAll.Checked == true)
                {
                    if (cbMonth.Checked == true && rdbRentAll.Checked == true)
                    {
                        SqlQeury = sql + " Where Format(datest,'MM-yyyy')='" + month + "'";
                    }
                    else if (cbYear.Checked == true && rdbRentAll.Checked == true)
                    {
                        SqlQeury=sql + " Where Year(datest)=" + year;
                    }
                    else
                    {
                        SqlQeury = sql;
                    }
                }

                dgvRent.Rows.Clear();
                table = new DataTable();
                da = new SqlDataAdapter(SqlQeury, con);
                da.Fill(table);
                if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
                {
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        dgvRent.Rows.Add(
                                 table.Rows[row][0].ToString(),
                                 table.Rows[row][1].ToString(),
                                 table.Rows[row][2].ToString(),
                                 table.Rows[row][3].ToString(),
                                 table.Rows[row][4].ToString(),
                                 table.Rows[row][5].ToString(),
                                 table.Rows[row][6].ToString(),
                                 DateTime.Parse(table.Rows[row][7].ToString()).ToString("dd-MM-yyyy"),
                                 DateTime.Parse(table.Rows[row][8].ToString()).ToString("dd-MM-yyyy"),
                                 table.Rows[row][9].ToString()
                            );
                        if (DateTime.Now.CompareTo(DateTime.Parse(table.Rows[row][8].ToString())) > 0 && table.Rows[row][9].ToString() == "ກຳລັງຢືມ")
                        {
                            dgvRent.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(247, 130, 82);
                        }
                    }
                }

                dgvRent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບໍ່ສາມາດສະແດງຂໍ້ມູນ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowMember(string m, string barc, string dat)
        {
            try
            {
                if (barc != "" && dat!="")
                {
                    cmd = new SqlCommand("Select mbid, fname, lname, tel From vw_RentBooks Where  barcode='" + barc + "' And datest='"+ DateTime.Parse(dat).ToString("yyyy-MMM-dd") +"' Group by	mbid,fname, lname, tel", con);
                }
                else
                {
                    cmd = new SqlCommand("Select mbid, fname, lname, tel From vw_RentBooks Where  mbid='" + m + "' Or fname =N'" + m + "' Or lname='" + m + "' Group by	mbid,fname, lname, tel ", con);
                }
                dgvMember.Rows.Clear();
                da = new SqlDataAdapter(cmd);
                table = new DataTable();
                da.Fill(table);
                if(table.Rows.Count>0 && table.Rows[0][0].ToString() != "")
                {
                    for(int row=0;row< table.Rows.Count; row++)
                    {
                        dgvMember.Rows.Add(
                            table.Rows[row][0].ToString(),
                            table.Rows[row][1].ToString(),
                            table.Rows[row][2].ToString(),
                            table.Rows[row][3].ToString()
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາສະແດງຂໍ້ມູນສະມາຊິກ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Shearch(string shearch)
        {
            try
            {
                ShowMember(shearch,"","");
                SqlQeury = "";
                if (rdbRenting.Checked == true)
                {
                    SqlQeury = sql + " Where barcode Like N'" + shearch + "' Or bname Like N'" + shearch + "%' Or typename Like N'" + shearch + "' Or mbid=N'" + shearch + "' Or fname =N'" + shearch + "' Or lname=N'" + shearch + "' And status=N'ກຳລັງຢືມ'";
                }
                else if (cbMonth.Checked == true)
                {
                    SqlQeury = sql + " Where barcode Like N'" + shearch + "' Or bname Like N'" + shearch + "%' Or typename Like N'" + shearch + "' Or status Like N'" + shearch + "' And Format(datest,'MM-yyyy')='" + month + "'";
                }
                else if (cbYear.Checked == true)
                {
                    SqlQeury = sql + " Where barcode Like N'" + shearch + "' Or bname Like N'" + shearch + "%' Or typename Like N'" + shearch + "' Or status Like N'" + shearch + "' And Year(datest)=" + year;
                }
                else
                {
                    SqlQeury = sql + " Where barcode Like N'" + shearch + "' Or bname Like N'" + shearch + "%' Or typename Like N'" + shearch + "' Or status Like N'" + shearch + "'";
                }

                table = new DataTable();
                da = new SqlDataAdapter(SqlQeury, con);
                da.Fill(table);
                if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
                {
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        dgvRent.Rows.Add(
                                 table.Rows[row][0].ToString(),
                                 table.Rows[row][1].ToString(),
                                 table.Rows[row][2].ToString(),
                                 table.Rows[row][3].ToString(),
                                 table.Rows[row][4].ToString(),
                                 table.Rows[row][5].ToString(),
                                 table.Rows[row][6].ToString(),
                                 DateTime.Parse(table.Rows[row][7].ToString()).ToString("dd-MM-yyyy"),
                                 DateTime.Parse(table.Rows[row][8].ToString()).ToString("dd-MM-yyyy"),
                                 table.Rows[row][9].ToString()
                            );
                        if (DateTime.Now.CompareTo(DateTime.Parse(table.Rows[row][8].ToString())) > 0 && table.Rows[row][9].ToString() == "ກຳລັງຢືມ")
                        {
                            dgvRent.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(247, 130, 82);
                        }
                    }
                }

                dgvRent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການຄົ້ນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
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
                this.SetDesktopLocation(MousePosition.X-mouX, MousePosition.Y - mouY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void frmShowRent_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        private void cbMonth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMonth.Checked == true)
            {
                cbYear.Checked = false;
                ShowData();
            }
        }

        private void rdbRenting_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void rdbRented_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void rdbRentAll_CheckedChanged(object sender, EventArgs e)
        {
            ShowData();
        }

        private void txtMemberID_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                Shearch(txtSearch.Text);
            }
            else
            {
                ShowData();
                lbMid.ResetText();
                lbName.ResetText();
                lbTel.ResetText();
            }
        }

        private void dgvRent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ShowMember("", dgvRent.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvRent.Rows[e.RowIndex].Cells[7].Value.ToString());
            }
        }

        private void cbYear_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYear.Checked == true)
            {
                cbMonth.Checked = false;
                ShowData();
            }
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
