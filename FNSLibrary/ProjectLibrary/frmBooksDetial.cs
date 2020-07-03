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
    public partial class frmBooksDetial : Form
    {
        public frmBooksDetial()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmBooksDetial(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        AutoCompleteStringCollection my_auto;
        string[] colname = { "ລະຫັດບາໂຄດ", "ຊື່ປຶ້ມ", "ຈຳນວນໜ້າ", "ISBN", "ໝວດ", "ປະເພດ","ລະຫັດຕູ້","ສະຖານະ" };
        int id = 0, count=0, qty=0;
        string[] data = new string[9];
        string[] author;
        string[] no_data = null;
       
        //Form
        frmAddNewBook newbook;

        public void Show_Data()
        {
            try
            {
                da = new SqlDataAdapter(@"SELECT dbo.tbBooks.barcode, dbo.tbBooks_Detail.bname, dbo.tbBooks_Detail.page, dbo.tbBooks_Detail.ISBN, dbo.tbCategory.name,              dbo.tbType.typename, dbo.tbBooks_Detail.tbdid, dbo.tbBooks.status
                        FROM   dbo.tbBooks INNER JOIN
                        dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN
                        dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN
                        dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid", con);
                ds.Clear();
                da.Fill(ds, "book");
                dgvbooks.DataSource = ds.Tables["book"];
                dgvbooks.Refresh();
                for(int i = 0; i < colname.Length; i++)
                {
                    dgvbooks.Columns[i].HeaderText = colname[i];
                    if (i != 0 && i != 2 && i != 6&&i!=7)
                    {
                        dgvbooks.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                    
                }

            }catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            try
            {

                cmd = new SqlCommand("Delete From tbBooks Where barcode=@barcode", con);
                cmd.Parameters.AddWithValue("barcode", dgvbooks.Rows[id].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();

                //int indx = 0;
                //char[] ch = dgvbooks.Rows[id].Cells[0].Value.ToString().ToCharArray();
                //string bid = "";

                //for (int i = 0; i < ch.Length; i++)
                //{
                //    if (char.IsLetter(ch[i]))
                //    {
                //        indx += 1;
                //    }
                //}
                //bid = dgvbooks.Rows[id].Cells[0].Value.ToString().Substring(0,indx);
                if (qty > 1)
                {
                    cmd = new SqlCommand("Update tbBooks_Detail Set Qty-=1 Where bid='" + lbID.Text + "'", con);
                    cmd.ExecuteNonQuery();
                }
                else if(qty<=1)
                {
                    cmd = new SqlCommand("Delete From tbBooks_Detail Where bid='" + lbID.Text + "'", con);
                    cmd.ExecuteNonQuery();
                }
                
                Show_Data();
                id = 0;
                btdel.Enabled = false;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ລົບຂໍ້ມູນບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Shearch_Data()
        {
            try
            {
                da = new SqlDataAdapter("select * From vw_Book Where barcode Like'"+txtSearch.Text+"%' Or bname Like N'"+txtSearch.Text+"%' Or name Like N'"+txtSearch.Text+"%' Or typename Like N'"+txtSearch.Text+"%' Or tbdid Like'"+txtSearch.Text+"%' Or status Like N'"+txtSearch.Text+"%'", con);
                ds.Clear();
                da.Fill(ds, "book");
                dgvbooks.DataSource = ds.Tables["book"];
                dgvbooks.Refresh();
                for (int i = 0; i < colname.Length; i++)
                {
                    dgvbooks.Columns[i].HeaderText = colname[i];
                    if (i != 0 && i != 2 && i != 6 && i != 7)
                    {
                        dgvbooks.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }

                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmBooksDetial_Load(object sender, EventArgs e)
        {
           // panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
            lbID.ResetText();
            lbBookName.ResetText();
            lbAllQty.ResetText();
            lbRentQty.ResetText();
            lbReserveQty.ResetText();
            lbYear.ResetText();
            lbAuthor1.ResetText();
            lbAuthor2.ResetText();
            lbAuthor3.ResetText();
            lbAuthor4.ResetText();

            btedit.Enabled = false;
            btdel.Enabled = false;
            MyModel.getSwitchLanguage();

            Show_Data();
        }

        private void dgvbooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            _home.Clear_PanelMenu();
            newbook = new frmAddNewBook(this, data, lbID.Text);
            //MessageBox.Show(data[1] + " " + data[3]);
            newbook.ShowDialog();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            newbook = new frmAddNewBook(this, no_data, "");
            newbook.ShowDialog();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            newbook = new frmAddNewBook(this, data, lbID.Text);
            //MessageBox.Show(data[1] + " " + data[3]);
            newbook.ShowDialog();
        }

        private void btdel_Click_1(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກບໍ່?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Delete();
            }
        }

        private void dgvbooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                btedit.Enabled = true;
                btdel.Enabled = true;
                for (int i = 0; i < dgvbooks.ColumnCount; i++)
                {
                    data[i] = dgvbooks.Rows[e.RowIndex].Cells[i].Value.ToString();
                }
                try
                {
                    author = new string[4];

                    cmd = new SqlCommand(@"Select tbBooks_Detail.bid, tbBooks_Detail.Qty, tbBooks_Detail.rentQty, tbBooks_Detail.reserQty, tbAthor.fname, tbAthor.lname, tbWrite.[Year] 
                    From tbBooks_Detail INNER JOIN tbWrite
                    ON tbBooks_Detail.bid = tbWrite.bid INNER JOIN tbAthor
                    ON tbWrite.athid = tbAthor.athid Where tbBooks_Detail.bname=N'" + dgvbooks.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", con);

                    //Set to Lable
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        lbID.Text = dr["bid"].ToString();
                        lbBookName.Text = dgvbooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                        qty = int.Parse(dr["Qty"].ToString());
                        lbAllQty.Text = qty.ToString() + " ຫົວ";
                        if (dr["rentQty"].ToString() != "")
                        {
                            lbRentQty.Text = dr["rentQty"].ToString() + " ຫົວ";
                        }
                        else
                        {
                            lbRentQty.Text = "0 ຫົວ";
                        }
                        if (dr["reserQty"].ToString() != "")
                        {
                            lbReserveQty.Text = dr["reserQty"].ToString() + " ຫົວ";
                        }
                        else
                        {
                            lbReserveQty.Text = "0 ຫົວ";
                        }
                        lbYear.Text = dr["Year"].ToString();
                        author[count] = dr["fname"].ToString()+" "+dr["lname"].ToString();
                        count++;
                        //MessageBox.Show("Has data2");
                    }

                    Label[] author_name = { lbAuthor1, lbAuthor2, lbAuthor3, lbAuthor4};

                    for (int i=0; i < author.Length; i++)
                    {
                        if (author[i] != null)
                        {
                            author_name[i].Text = (i+1).ToString()+". "+author[i];
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    dr.Close();
                    count = 0;
                }
            }
            else
            {
                btedit.Enabled = false;
                btdel.Enabled = false;
            }
        }

        private void dgvbooks_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            btedit.Enabled = false;
            btdel.Enabled = false;
        }

        private void groupBox1_MouseCaptureChanged(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            btedit.Enabled = false;
            btdel.Enabled = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "")
            {
                Shearch_Data();
            }
            else
            {
                Show_Data();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void frmBooksDetial_Click(object sender, EventArgs e)
        {
            btedit.Enabled = false;
            btdel.Enabled = false;
        }
    }
}
