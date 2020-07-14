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
    public partial class frmBookLost : Form
    {
        public frmBookLost()
        {
            InitializeComponent();
        }

        SqlConnection con = MyConnected.getConnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        SqlDataReader dr;
        DataTable table;
        AutoCompleteStringCollection auto;
        decimal cost = 0, total = 0;
        string rentid = "";

        private void Lost_Cost()
        {
            try
            {
                cmd = new SqlCommand("Select price From tbFine",con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    cost = dr.GetDecimal(0);
                    lbCost.Text = $"{cost.ToString()} ກີບ/1ໜ້າ";
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
                txtMemberID.AutoCompleteCustomSource = auto;
                txtMemberID.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtMemberID.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        private void Show_Data()
        {
            try
            {
                if (cbAll.Checked == true)
                {
                    table = new DataTable();
                    da = new SqlDataAdapter(@"Select * From vw_BookLost", con);
                    da.Fill(table);
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        dgvBooksLost.Rows.Add(
                            table.Rows[row][0].ToString(),
                            table.Rows[row][1].ToString(),
                            table.Rows[row][2].ToString(),
                            table.Rows[row][3].ToString(),
                            table.Rows[row][4].ToString(),
                            table.Rows[row][5].ToString(),
                            table.Rows[row][6].ToString(),
                            table.Rows[row][7].ToString(),
                            DateTime.Parse(table.Rows[row][8].ToString()).ToString("dd-MM-yyyy")
                            );
                    }
                }
                else
                {
                    dgvBooksLost.Rows.Clear();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void ShowBarcord()
        {
            //try
            //{
            //    cmd = new SqlCommand("Select barcode From tbRent_Book", con);
            //    dr = cmd.ExecuteReader();
            //    while (dr.Read())
            //    {
            //        auto.Add(dr["barcode"].ToString());
            //    }
            //    txtMemberID.AutoCompleteCustomSource = auto;
            //    txtMemberID.AutoCompleteMode = AutoCompleteMode.Suggest;
            //    txtMemberID.AutoCompleteSource = AutoCompleteSource.CustomSource;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error load data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //finally
            //{
            //    dr.Close();
            //}
        }
        private void AddLostBooks(string memberid)
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvBooksLost.Rows.Clear();
                da = new SqlDataAdapter(@"SELECT barcode, bname, page, qty, name, typename, tbdid, datest, mbid, fname , lname, tel, rentid From vw_ShowLostBooks Where mbid='" + memberid + "' and status=N'ກຳລັງຢືມ'", con);
                da.Fill(table);
                for (int row = 0; row < table.Rows.Count; row++)
                {

                    decimal page_per_qty = 0;
                    page_per_qty = int.Parse(table.Rows[row][2].ToString()) * int.Parse(table.Rows[row][3].ToString()) * cost;


                    dgvBooksLost.Rows.Add(
                        table.Rows[row][0].ToString(),
                        table.Rows[row][1].ToString(),
                        table.Rows[row][2].ToString(),
                        table.Rows[row][3].ToString(),
                        page_per_qty.ToString(),
                        table.Rows[row][4].ToString(),
                        table.Rows[row][5].ToString(),
                        table.Rows[row][6].ToString(),
                       DateTime.Parse(table.Rows[row][7].ToString()).ToString("dd-MM-yyyy")
                        );
                    lbMemberID.Text = table.Rows[row][8].ToString();
                    lbMemberName.Text =$"{table.Rows[row][9].ToString()} {table.Rows[row][10].ToString()}";
                    lbTel.Text = table.Rows[row][11].ToString();
                    rentid = table.Rows[row][12].ToString();
                }
                btsave.Enabled = true;
                cbAll.Enabled = false;
                lbAllCost.Text = $"{(from DataGridViewRow row in dgvBooksLost.Rows where row.Cells[4].FormattedValue.ToString() != string.Empty select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString()} ກີບ";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
}
        private void Save()
        {
            try
            {
                for (int couut = 0; couut< dgvBooksLost.RowCount; couut++)
                {
                    cmd = new SqlCommand("Insert into tbBook_Lost(barcode, qty, cost, date) Values(@barcode, @qty, @cost,  @date)", con);
                    cmd.Parameters.AddWithValue("barcode", DbType.String).Value = dgvBooksLost.Rows[couut].Cells[0].Value.ToString();
                    cmd.Parameters.AddWithValue("qty", DbType.Int64).Value = int.Parse(dgvBooksLost.Rows[couut].Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("cost", DbType.Decimal).Value = decimal.Parse(dgvBooksLost.Rows[couut].Cells[4].Value.ToString());
                    cmd.Parameters.AddWithValue("date", DbType.Date).Value = DateTime.Now.Date;
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                        da = new SqlDataAdapter("Select bid From tbBooks Where barcode='" + dgvBooksLost.Rows[couut].Cells[0].Value.ToString() + "'", con);
                        table = new DataTable();
                        table.Clear();
                        da.Fill(table);

                        //Update out of from tbRent_Book
                        cmd = new SqlCommand("Update tbRent_Book Set status=N'ສົ່ງແລ້ວ' Where barcode='" + dgvBooksLost.Rows[couut].Cells[0].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                        
                        //Update out of from tbBooks
                        cmd = new SqlCommand("Update tbBooks Set status=N'ເສຍ' Where barcode='" + dgvBooksLost.Rows[couut].Cells[0].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();

                        //Delete Upadte Qty of tbBooks_Detial
                        cmd = new SqlCommand("Update tbBooks_Detail Set rentQty+="+int.Parse(dgvBooksLost.Rows[couut].Cells[3].Value.ToString())+" Where bid='" + table.Rows[0][0].ToString() + "'", con);
                        cmd.ExecuteNonQuery();
                    }
                }
                MyMessageBox.ShowMesage("ບັນທືກສຳເລັດແລ້ວ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dgvBooksLost.Rows.Clear();
                if (dgvBooksLost.Rows.Count <= 0)
                {
                    txtMemberID.Clear();
                    btsave.Enabled = false;
                    cbAll.Enabled = true;
                    cbAll.Checked = true;
                }
                lbMemberID.ResetText();
                lbMemberName.ResetText();
                lbTel.ResetText();
        }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        private void Delete(string barcode, string bid, int qty)
        {
            try
            {
                DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກບໍ່?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete From tbBook_Lost Where barcode='" + barcode + "'", con);
                   // cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete: "+cmd.ExecuteNonQuery().ToString());

                    cmd = new SqlCommand("Update tbBooks Set status=N'ຫວ່າງ' Where barcode='" + barcode + "'", con);
                    MessageBox.Show("Update 1: "+cmd.ExecuteNonQuery().ToString()); 
                    
                    cmd = new SqlCommand("Update tbBooks_Detail Set Qty+="+qty+" Where bid='" + bid + "'", con);
                    MessageBox.Show("Update 2: "+cmd.ExecuteNonQuery().ToString());

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btBookLost_Click(object sender, EventArgs e)
        {
            frmBookLost lost = new frmBookLost();
            lost.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Show_Data();
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            cbAll.Checked = false;
            if (txtMemberID.Text != "")
            {
                cbAll.Checked = false;
                AddLostBooks(txtMemberID.Text);
            }
            else
            {
                dgvBooksLost.Rows.Clear();
                cbAll.Enabled = true;
                btsave.Enabled = false;
                cbAll.Checked = true;
            }
        }

        private void frmBookLost_Load(object sender, EventArgs e)
        {
            //ShowBarcord();
            cbAll.Checked = true;
            LoadMemberID();
            Lost_Cost();
            lbAllCost.ResetText();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if(txtMemberID.Text!="" && cbAll.Checked==false && cbAll.Enabled==false && dgvBooksLost.Rows.Count > 0)
            {
                Save();
            }
        }

        private void dgvBooksLost_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9 && cbAll.Checked==false && cbAll.Enabled==false && txtMemberID.Text!="")
            {
                dgvBooksLost.Rows.RemoveAt(e.RowIndex);
                if (dgvBooksLost.Rows.Count <= 0)
                {
                    txtMemberID.Clear();
                    cbAll.Enabled = true;
                    btsave.Enabled = false;
                }
                lbAllCost.Text = $"{(from DataGridViewRow row in dgvBooksLost.Rows where row.Cells[4].FormattedValue.ToString() != string.Empty select Convert.ToDecimal(row.Cells[4].FormattedValue)).Sum().ToString()} ກີບ";
            }
            else if(e.ColumnIndex == 9 && cbAll.Checked == true && cbAll.Enabled == true && txtMemberID.Text == "")
            {
                try
                {
                    cmd = new SqlCommand("Select bid From tbBooks Where barcode='" + dgvBooksLost.Rows[e.RowIndex].Cells[0].ToString() + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    Delete(dgvBooksLost.Rows[e.RowIndex].Cells[0].Value.ToString(), dr["bid"].ToString(), int.Parse(dgvBooksLost.Rows[e.RowIndex].Cells[3].ToString()));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dr.Close();
                }
            }
        }
    }
}
