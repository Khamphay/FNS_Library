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
using Guna.UI.WinForms;

namespace ProjectLibrary
{
    public partial class frmReserveInfor : Form
    {
        Form1 _home;
        public frmReserveInfor(Form1 home)
        {
            InitializeComponent();
            _home = home;
            lbReserveID.ResetText();
            if (MyModel.staff[1] == null && MyModel.staff[4] == null && MyModel.staff[5] == null)
            {
                btRent.Enabled = true;
                btRent.Size = new Size(0, 0);
            }
        }

        SqlConnection con = MyConnected.getConnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        DateTime dateNow = DateTime.Now;
        DateTime dateExpire;
        AutoCompleteStringCollection autoCom = new AutoCompleteStringCollection();
        DataTable table;
        string barcode = "", bookid="";
        string[] colname = { "ລະຫັດ", "ຊື່ປື້ມ", "ຈຳນວນໜ້າ", "ໝວດ", "ປະເພດ", "ລະຫັດຕູ້", "ວັນທີຈ້ອງ", "ວັນທີໝົດອາຍຸ" };
        int index;

        private void LoadData()
        {
            try
            {
                cmd = new SqlCommand("Select rsid, mid, fname, lname From vw_Reserves_Books", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    autoCom.Add(dr["rsid"].ToString());
                    autoCom.Add(dr["mid"].ToString());
                    autoCom.Add(dr["fname"].ToString());
                    autoCom.Add(dr["lname"].ToString());
                }
                txtMemberID.AutoCompleteCustomSource = autoCom;
                txtMemberID.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtMemberID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }catch (Exception ex)
            {
                MessageBox.Show("Error Load data: " + ex.Message,"Error");
            }
            finally
            {
                dr.Close();
            }
        }
        private void ShowData()
        {
            try
            {

                //ds = new DataSet();
                //ds.Clear();
                table = new DataTable();
                table.Clear();
                dgvReserInfor.Rows.Clear();
                da = new SqlDataAdapter("Select barcode, bname, page, name, typename, tbdid, dateSt, dateEd From vw_Reserves_Books", con);
                da.Fill(table);
                for(int i=0; i< table.Rows.Count; i++)
                {
                    dgvReserInfor.Rows.Add(
                                        table.Rows[i][0].ToString(),
                                        table.Rows[i][1].ToString(),
                                        table.Rows[i][2].ToString(),
                                        table.Rows[i][3].ToString(),
                                        table.Rows[i][4].ToString(),
                                        table.Rows[i][5].ToString(),
                                         DateTime.Parse(table.Rows[i][6].ToString()).ToString("dd-MM-yyyy"),
                                        DateTime.Parse(table.Rows[i][7].ToString()).ToString("dd-MM-yyyy")
                                        ) ;
                }
                

                //dgvReserInfor.DataSource = ds.Tables["Reserve"];
                //dgvReserInfor.Refresh();

                //for (int i = 0; i < colname.Length; i++)
                //{
                //    dgvReserInfor.Columns[i].HeaderText = colname[i];
                //}
                //dgvReserInfor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch
            {

            }
        }
        private void Delete()
        {
            try
            {
                cmd = new SqlCommand("Delete From tbReserve Where barcode=@barcode", con);
                cmd.Parameters.AddWithValue("barcode", barcode);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Update tbBooks_Detail Set reserQty-=1  Where bid=@id", con);
                cmd.Parameters.AddWithValue("id", bookid);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand("Update tbBooks Set status=N'ຫວ່າງ'  Where barcode=@barcode", con);
                cmd.Parameters.AddWithValue("barcode", dgvReserInfor.Rows[index].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();

                ShowData();
                barcode = "";
            }catch (Exception ex)
            {
                MessageBox.Show("Error Load data: " + ex.Message, "Error");
            }
        }
        private void AddToRent()
        {
            List<AddRentBooks> addList = new List<AddRentBooks>();
            foreach (DataGridViewRow row in dgvReserInfor.Rows)
            {
                addList.Add(new AddRentBooks
                {
                    getBarCode = row.Cells[0].Value.ToString(),
                    getBookName = row.Cells[1].Value.ToString(),
                    getPage = row.Cells[2].Value.ToString(),
                    getQty = 1,
                    getCatName = row.Cells[3].Value.ToString(),
                    getTypeName = row.Cells[4].Value.ToString(),
                    getTableID = row.Cells[5].Value.ToString(),
                    getMemberID=txtMemberID.Text
                });
            }
            frmRentBook rentBook = new frmRentBook(_home);
            rentBook.listVal = addList;
            rentBook.Reserve = true;
            _home.ShowRentBooks_From_Reserve(rentBook);


        }
        private void frmReserveInfor_Load(object sender, EventArgs e)
        {
            LoadData();
           // ShowData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtMemberID.Text != "")
                {
                    lbReserveID.ResetText();
                    table = new DataTable();
                    table.Clear();
                    dgvReserInfor.Rows.Clear();
                    da = new SqlDataAdapter("Select barcode, bname, page, name, typename, tbdid, dateSt, dateEd, rsid From vw_Reserves_Books Where mid Like'"+txtMemberID.Text+"%'", con);
                    da.Fill(table);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        dgvReserInfor.Rows.Add(
                                            table.Rows[i][0].ToString(),
                                            table.Rows[i][1].ToString(),
                                            table.Rows[i][2].ToString(),
                                            table.Rows[i][3].ToString(),
                                            table.Rows[i][4].ToString(),
                                            table.Rows[i][5].ToString(),
                                             DateTime.Parse(table.Rows[i][6].ToString()).ToString("dd-MM-yyyy"),
                                            DateTime.Parse(table.Rows[i][7].ToString()).ToString("dd-MM-yyyy")
                                            );
                        lbReserveID.Text= table.Rows[i][8].ToString();
                    }
                }
                else
                {
                   // ShowData();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Search", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvReserInfor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                index = e.RowIndex;
                if (e.RowIndex >= 0)
                {
                    barcode = dgvReserInfor.Rows[e.RowIndex].Cells[0].Value.ToString();
                    cmd = new SqlCommand("Select rsid, bid From vw_Reserves_Books Where barcode ='" + barcode + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        lbReserveID.Text = dr["rsid"].ToString();
                        bookid = dr["bid"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

        private void btRent_Click(object sender, EventArgs e)
        {
            if (txtMemberID.Text != "" && lbReserveID.Text != ""&& MyModel.staff[1] != null && MyModel.staff[4] != null && MyModel.staff[5] != null)
            {
                AddToRent();
                this.Close();
            }
            else
            {
                MessageBox.Show("ກະລຸນາປ້ອນລະຫັດສະມາຊິກ", "Warring", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvReserInfor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                barcode = dgvReserInfor.Rows[e.RowIndex].Cells[0].Value.ToString();
                Delete();
            }
        }

        private void dgvReserInfor_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //    try
            //    {
            //        if (e.RowIndex >= 0)
            //        {
            //            cmd = new SqlCommand("Select bid From tbBooks Where barcode='" + dgvReserInfor.Rows[e.RowIndex].Cells[0].Value.ToString() + "'",con);
            //            dr = cmd.ExecuteReader();
            //            if (dr.HasRows)
            //            {
            //                dr.Read();
            //                bookid = dr["bid"].ToString();
            //            }
            //        }
            //    }catch (Exception ex)
            //    {
            //        MessageBox.Show("Error: " + ex.Message, "Error");
            //    }
            //    finally
            //    {
            //        dr.Close();
            //    }

        }
    }
}
