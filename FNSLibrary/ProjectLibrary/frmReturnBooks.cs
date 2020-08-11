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
    public partial class frmReturnBooks : Form
    {
        public frmReturnBooks()
        {
            InitializeComponent();
            CostFine();
        }

        Form1 _home;
        public frmReturnBooks(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable table;
        DateTime dateNow, dateExpire;

        double priceFine = 0.0, priceTotal=0.0;
        int betweendate = 0, qty=0;
        string brd = "";
        //Connect BarcodeReader And Read Data
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            char c = (char)keyData;
            brd += c;
            if (c == (char)Keys.Return)
            {
                MessageBox.Show("Conn:" + brd);
                ShowBooks(brd);
                brd = "";
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void ReturnBook()
        {
            try
            {
                for(int i = 0; i <= dgvReturnbooks.RowCount-1; i++)
                {
                    string bid = "";
                    table = new DataTable();
                    table.Clear();
                    da = new SqlDataAdapter("Select bid From tbBooks Where barcode='" + dgvReturnbooks.Rows[i].Cells[0].Value.ToString() + "'", con);
                    da.Fill(table);
                    bid = table.Rows[0][0].ToString();

                    if (bid != "")
                    {
                        cmd = new SqlCommand("Update tbRent_Book SET status=N'ສົ່ງແລ້ວ' Where barcode='" + dgvReturnbooks.Rows[i].Cells[0].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("Update tbBooks SET status=N'ຫວ່າງ' Where barcode='" + dgvReturnbooks.Rows[i].Cells[0].Value.ToString() + "'", con);
                        cmd.ExecuteNonQuery();

                        cmd = new SqlCommand("Update tbBooks_Detail SET rentQty-=" + int.Parse(dgvReturnbooks.Rows[i].Cells[5].Value.ToString())+ " Where bid='"+bid+"'", con);
                        cmd.ExecuteNonQuery();
                    }                    
                }
                Clear_Data();
                
            }catch(Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CostFine()
        {
            try
            {
                cmd = new SqlCommand("Select price From tbFine", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    priceFine = double.Parse(dr["price"].ToString());
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void ShowBooks(string barcode)
        {
            try
            {
                table = new DataTable();
                table.Clear();
                da = new SqlDataAdapter("Select rentid, bid, barcode, bname, page, name, typename, qty, tbdid, datest, dateed, mbid, fname, lname, qty_total From vw_Return Where barcode='" + barcode+ "'", con);
                da.Fill(table);

                if (table.Rows.Count > 0)
                {
                    lbID.Text = table.Rows[0][0].ToString();
                    txtRentId.Text = table.Rows[0][0].ToString();
                    lbMemID.Text = table.Rows[0][11].ToString();
                    lbMemberName.Text = table.Rows[0][12].ToString() + " " + table.Rows[0][13].ToString();
                    lbDateSt.Text = DateTime.Parse(table.Rows[0][9].ToString()).ToString("dd-MM-yyyy");
                    lbDateExpire.Text = DateTime.Parse(table.Rows[0][10].ToString()).ToString("dd-MM-yyyy");
                    lbRentQty.Text = table.Rows[0][14].ToString()+" ຫົວ";
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                       // qty += int.Parse(table.Rows[0][7].ToString());
                        dgvReturnbooks.Rows.Add(
                            table.Rows[i][2].ToString(),
                            table.Rows[i][3].ToString(),
                            table.Rows[i][4].ToString(),
                            table.Rows[i][5].ToString(),
                            table.Rows[i][6].ToString(),
                            table.Rows[i][7].ToString(),
                            table.Rows[i][8].ToString()
                            );
                    }
                    lbShowBooksExpire.Text = "0 ວັນ";
                    // lbRentQty.Text = qty.ToString();
                    dateExpire = DateTime.Parse(table.Rows[0][10].ToString());
                    if (dateNow.CompareTo(dateExpire) == 1)
                    {
                        TimeSpan tsp = dateNow - dateExpire;
                        betweendate = tsp.Days;
                        lbDateExpire.Text = betweendate.ToString();
                        lbPrice.Text = priceFine.ToString();
                        priceTotal = qty * betweendate;
                        lbPriceTotal.Text = priceTotal.ToString();
                        lbShowBooksExpire.Text = "ສົ່ງຊ້າ: " + betweendate.ToString() + " ວັນ";
                    }
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear_Data()
        {
            txtbarcode.Clear();
            txtRentId.Clear();
            dgvReturnbooks.Rows.Clear();
        }
        private void btBookLost_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            frmBookLost lost = new frmBookLost();
            lost.Show();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            if (dgvReturnbooks.RowCount > 0)
            {
                ReturnBook();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {
            ShowBooks(txtbarcode.Text);
        }

        private void dgvReturnbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                dgvReturnbooks.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void txtbid_KeyDown(object sender, KeyEventArgs e)
        {
            txtbarcode.Focus();
        }

        private void txtRentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtbid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }
        private void frmReturnBooks_Load(object sender, EventArgs e)
        {
            lbRentQty.Text = "0";
            lbDateExpire.Text = "0";
            lbPrice.Text = priceFine.ToString("#,###.#0") + " ກີບ";
            lbPriceTotal.Text = "0";
            lbPriceTotal.Text = "0";
        }
    }
}
