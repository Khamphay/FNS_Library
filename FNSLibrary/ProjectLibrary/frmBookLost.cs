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
                da = new SqlDataAdapter(@"SELECT barcode, bname, page, qty, name, typename, tbdid, datest, mbid, fname , lname, tel From vw_ShowLostBooks Where mbid='" + memberid + "' and status=N'ກຳລັງຢືມ'", con);
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
                for(int couut = dgvBooksLost.Rows.Count-1; couut >= 0; couut--)
                {
                    cmd = new SqlCommand("Insert into tbBook_Lost(barcode, bname, page, qty, cost, catgname, typename, tbdid, date) Values(@barcode, @bname, @page, @qty, @cost, @catgname, @typename, @tbdid,  @date)", con);
                    cmd.Parameters.AddWithValue("barcode", DbType.String).Value = dgvBooksLost.Rows[couut].Cells[0].Value.ToString();
                    cmd.Parameters.AddWithValue("bname", DbType.String).Value = dgvBooksLost.Rows[couut].Cells[1].Value.ToString();
                    cmd.Parameters.AddWithValue("page", DbType.Int64).Value = int.Parse(dgvBooksLost.Rows[couut].Cells[2].Value.ToString());
                    cmd.Parameters.AddWithValue("qty", DbType.Int64).Value = int.Parse(dgvBooksLost.Rows[couut].Cells[3].Value.ToString());
                    cmd.Parameters.AddWithValue("cost", DbType.Decimal).Value = decimal.Parse(dgvBooksLost.Rows[couut].Cells[4].Value.ToString());
                    cmd.Parameters.AddWithValue("catgname", DbType.String).Value = dgvBooksLost.Rows[couut].Cells[5].Value.ToString();
                    cmd.Parameters.AddWithValue("typename", DbType.String).Value = dgvBooksLost.Rows[couut].Cells[6].Value.ToString();
                    cmd.Parameters.AddWithValue("tbdid", DbType.String).Value = dgvBooksLost.Rows[couut].Cells[7].Value.ToString();
                    cmd.Parameters.AddWithValue("date", DbType.Date).Value = DateTime.Now;
                    if (cmd.ExecuteNonQuery() == 1)
                    {

                        da = new SqlDataAdapter("Select bid From tbBooks Where barcode='" + dgvBooksLost.Rows[couut].Cells[0].Value.ToString() + "'", con);
                        table = new DataTable();
                        table.Clear();
                        da.Fill(table);

                        //Delete out of from tbBooks
                        cmd = new SqlCommand("Delete From tbBooks Where barcode='" + dgvBooksLost.Rows[couut].Cells[0].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();

                        //Delete Upadte Qty of tbBooks_Detial
                        cmd = new SqlCommand("Update tbBooks_Detail Set bid='" + table.Rows[0][0].ToString() + "'", con);
                        cmd.ExecuteNonQuery();

                        dgvBooksLost.Rows.RemoveAt(couut);
                    }
                }
                if (dgvBooksLost.Rows.Count <= 0)
                {
                    txtMemberID.Clear();
                    btsave.Enabled = false;
                    cbAll.Enabled = true;
                    cbAll.Checked = true;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete(string barcode)
        {
            try
            {
                DialogResult result = MessageBox.Show("Are you sure to delete?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (result == DialogResult.OK)
                {
                    cmd = new SqlCommand("Delete From tbBook_Lost Where barcode='" + barcode + "'", con);
                    cmd.ExecuteNonQuery();
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
            if (cbAll.Checked == true)
            {
                table = new DataTable();
                da = new SqlDataAdapter("Select * From tbBook_Lost", con);
                da.Fill(table);
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    dgvBooksLost.Rows.Add(
                        table.Rows[row][0].ToString(),
                        table.Rows[row][2].ToString(),
                        table.Rows[row][3].ToString(),
                        table.Rows[row][4].ToString(),
                        table.Rows[row][5].ToString(),
                        table.Rows[row][6].ToString(),
                        table.Rows[row][7].ToString());
                }
            }
            else
            {
                dgvBooksLost.Rows.Clear();
            }
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            cbAll.Checked = false;
            if (txtMemberID.Text != "")
            {
                AddLostBooks(txtMemberID.Text);
            }
            else
            {
                dgvBooksLost.Rows.Clear();
                cbAll.Enabled = true;
                btsave.Enabled = false;
            }
        }

        private void frmBookLost_Load(object sender, EventArgs e)
        {
            //ShowBarcord();
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
                Delete(dgvBooksLost.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }
    }
}
