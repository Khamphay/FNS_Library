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
    public partial class frmRentBook : Form
    {
        public frmRentBook()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmRentBook(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable table;
        AutoCompleteStringCollection auto;
        DateTime dateNow;
        string maxid = "", status = "ກຳລັງຢືມ", rsid = "", myBarcode = "";
        int newid = 0, indx, day=0;
        public bool Reserve = false;
        DateTime ExpireMember;

        public List<AddRentBooks> listVal;
        public void AddData()
        {
            CancalarData();
            if (listVal != null)
            {
                foreach (AddRentBooks list in listVal)
                {
                    int add = dgvRentbooks.Rows.Add();
                    dgvRentbooks.Rows[add].Cells[0].Value = list.getBarCode;
                    dgvRentbooks.Rows[add].Cells[1].Value = list.getBookName;
                    dgvRentbooks.Rows[add].Cells[2].Value = list.getPage;
                    dgvRentbooks.Rows[add].Cells[3].Value = list.getQty;
                    dgvRentbooks.Rows[add].Cells[4].Value = list.getCatName;
                    dgvRentbooks.Rows[add].Cells[5].Value = list.getTypeName;
                    dgvRentbooks.Rows[add].Cells[6].Value = list.getTableID;
                    dgvRentbooks.Rows[add].Cells[7].Value = dateST.Value.ToString("dd-MM-yyyy");
                    dgvRentbooks.Rows[add].Cells[8].Value = dateED.Value.ToString("dd-MM-yyyy");
                    txtmemberid.Text = list.getMemberID;
                }
            }
            listVal.Clear();
        }
        private void AddDataToDgv(string barcode)
        {
            try
            {
                cmd = new SqlCommand(@"Select tbBooks.barcode, tbBooks_Detail.bname, tbBooks_Detail.[page], tbCategory.[name], tbType.typename, tbBooks_Detail.tbdid, tbBooks.status  From tbBooks_Detail INNER JOIN tbBooks On tbBooks_Detail.bid = tbBooks.bid INNER JOIN tbCategory ON tbBooks_Detail.catgid = tbCategory.catgid INNER JOIN tbType ON tbBooks_Detail.typeid = tbType.typeid Where tbBooks.barcode='" + barcode+ "'", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    if (dr["status"].ToString()!="ກຳລັງຈອງ")
                    {
                        dgvRentbooks.Rows.Add(
                        dr["barcode"].ToString(),
                        dr["bname"].ToString(),
                        dr["page"].ToString(),
                        "1",
                        dr["name"].ToString(),
                        dr["typename"].ToString(),
                        dr["tbdid"].ToString(),
                        dateST.Value.ToString("dd-MM-yyyy"),
                        dateED.Value.ToString("dd-MM-yyyy")
                        );
                    }
                    else
                    {
                        MessageBox.Show("This book has reservation", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    //txtBName.Clear();
                    //txtPage.Clear();
                    //txtqty.Clear();
                    //txttable.Clear();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນປຶ້ມ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }

        }
        private void CancalarData()
        {
            day = 4;
            //MessageBox.Show(dateST.Value.DayOfWeek.ToString());
            if (dateST.Value.DayOfWeek.ToString() == "Saturday")
            {
                day += 2;
            }
            else if (dateST.Value.DayOfWeek.ToString() == "Sunday")
            {
                day += 1;
            }
            else
            {
                for (int i = 1; i <= 5; i++)
                {
                    dateNow = dateST.Value;
                    if (dateNow.DayOfWeek.ToString() == "Saturday" || dateNow.DayOfWeek.ToString() == "Sunday")
                    {
                        day += 1;
                    }
                    dateNow = dateNow.AddDays(i);
                }
            }
            dateNow = dateST.Value;
            dateED.Value = dateNow.AddDays(day);
        }
        private void MaxID()
        {
            char[] cid;
            int index = 0;
            try
            {
                cmd = new SqlCommand("Select MAX(rentid) as [MaxID] From tbRent_Detail", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["MaxID"].ToString() != "")
                {
                    cid = dr["MaxID"].ToString().ToCharArray();
                    for (int i = 0; i < cid.Length; i++)
                    {
                        if (char.IsLetter(cid[i]))
                        {
                            index += 1;
                        }
                    }
                    maxid = dr["MaxID"].ToString().Substring(0, index);
                    newid = int.Parse(dr["MaxID"].ToString().Substring(index));
                    txtRentId.Text = $"{maxid}00{newid + 1}";
                }
                else
                {
                    //txtRentId.Enabled = true;
                    txtRentId.Text = "Rent001";
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງລະຫັດການຈອງ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                txtmemberid.AutoCompleteCustomSource = auto;
                txtmemberid.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtmemberid.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງບັດ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void FillData_ToLable()
        {
            try
            {
                cmd = new SqlCommand("Select fname, lname, tel, dateREd From tbMember Where mid='" + txtmemberid.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    lbMemberID.Text = txtmemberid.Text;
                    lbMemberName.Text = dr["fname"].ToString()+" "+ dr["lname"].ToString();
                    lbTel.Text = dr["tel"].ToString();
                    ExpireMember = DateTime.Parse(dr["dateREd"].ToString());

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
        private void Check_MemberRent()
        {
            try
            {
                cmd = new SqlCommand("Select mbid, SUM(tbRent_Book.qty) as qty From tbRent_Detail Inner Join tbRent_Book On tbRent_Detail.rentid = tbRent_Book.rentid Where tbRent_Book.status=N'ກຳລັງຢືມ' AND tbRent_Detail.mbid='" + txtmemberid.Text + "' Group By mbid", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["mbid"].ToString() == txtmemberid.Text && dr.GetInt32(1)==3)
                {
                    MyMessageBox.ShowMesage("ບໍ່ສາມາດຢືມໄດ້ ເນື່ອງຈາກທ່ານໄດ້ຢືມປຶ້ມຄົບຕາມຈຳນວນທີ່ກຳນົດແລ້ວ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btsave.Enabled = false;
                    txtmemberid.Clear();
                    dr.Close();
                }
                else
                {
                    dr.Close();
                    table = new DataTable();
                    table.Clear();
                    dgvRentbooks.Rows.Clear();
                    da = new SqlDataAdapter(@" SELECT tbReserve.barcode, tbBooks_Detail.bname, tbBooks_Detail.page, tbCategory.name, tbType.typename, tbBooks_Detail.tbdid, tbReserve_Detail.rsid FROM   tbBooks_Detail INNER JOIN
                        tbBooks ON tbBooks_Detail.bid = tbBooks.bid INNER JOIN
                        tbType ON tbBooks_Detail.typeid = tbType.typeid INNER JOIN
                        tbReserve ON tbBooks.barcode = tbReserve.barcode INNER JOIN
                        tbReserve_Detail ON tbReserve.rsid = tbReserve_Detail.rsid INNER JOIN
                        tbCategory ON tbBooks_Detail.catgid = tbCategory.catgid Where tbReserve_Detail.mid='" + txtmemberid.Text+"'", con);
                    da.Fill(table);
                    for (int row = 0; row < table.Rows.Count; row++)
                    {
                        dgvRentbooks.Rows.Add(
                            table.Rows[row][0].ToString(),
                            table.Rows[row][1].ToString(),
                            table.Rows[row][2].ToString(),
                            "1",
                            table.Rows[row][3].ToString(),
                            table.Rows[row][4].ToString(),
                            table.Rows[row][5].ToString(),
                            dateST.Value.ToString("dd-MM-yyyy"),
                            dateED.Value.ToString("dd-MM-yyyy")
                            );
                        rsid = table.Rows[row][6].ToString();
                    }
                    Reserve = true;
                    btsave.Enabled = true;
                    txtbarcode.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການກວດສອບຂໍ້ມູນການຢືມ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadBookID()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select barcode From tbBooks Where status=N'ຫວ່າງ' OR status=N'ກຳລັງຈອງ'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.Add(dr["barcode"].ToString());
                }
                txtbarcode.AutoCompleteCustomSource = auto;
                txtbarcode.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtbarcode.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert into tbRent_Detail Values(@rid, @mid, @qty, @datest, @dated)", con);
                cmd.Parameters.AddWithValue("rid", txtRentId.Text);
                cmd.Parameters.AddWithValue("mid", txtmemberid.Text);
                cmd.Parameters.AddWithValue("qty", dgvRentbooks.Rows.Count);
                cmd.Parameters.AddWithValue("datest", dateST.Value);
                cmd.Parameters.AddWithValue("dated", dateED.Value);
               
                if (cmd.ExecuteNonQuery() == 1)
                {
                    for(int i = 0; i < dgvRentbooks.Rows.Count; i++)
                    {
                        cmd = new SqlCommand("Insert into tbRent_Book Values(@rid, @barcode, @qty, @status)", con);
                        cmd.Parameters.AddWithValue("rid", txtRentId.Text);
                        cmd.Parameters.AddWithValue("barcode", dgvRentbooks.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("qty", dgvRentbooks.Rows[i].Cells[3].Value.ToString());
                        cmd.Parameters.AddWithValue("status", status);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            cmd = new SqlCommand("Update tbBooks Set status=@status Where barcode=@barcode", con);
                            cmd.Parameters.AddWithValue("barcode", dgvRentbooks.Rows[i].Cells[0].Value.ToString());
                            cmd.Parameters.AddWithValue("status", status);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                string bid = "";
                                cmd = new SqlCommand("Select bid From tbBooks Where barcode='" + dgvRentbooks.Rows[i].Cells[0].Value.ToString() + "'", con);
                                da = new SqlDataAdapter();
                                MessageBox.Show("Ar (" + i + "): " + dgvRentbooks.Rows[i].Cells[0].Value.ToString());
                                table = new DataTable();
                                table.Clear();
                                da.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    bid = table.Rows[0][0].ToString();
                                }

                                cmd = new SqlCommand("Update tbBooks_Detail Set rentQty+=" + int.Parse(dgvRentbooks.Rows[i].Cells[3].Value.ToString()) + " Where bid='" + bid + "'", con);
                                cmd.ExecuteNonQuery();

                                if (Reserve == true)
                                {
                                    cmd = new SqlCommand(@"if ('"+ dgvRentbooks.Rows[i].Cells[0].Value.ToString() + "') in (Select barcode From tbReserve) Update tbBooks_Detail Set reserQty -= 1 Where bid = '" + bid + "'", con);
                                    if (cmd.ExecuteNonQuery() == 1)
                                    {
                                        cmd = new SqlCommand("Delete From  tbReserve Where barcode='" + dgvRentbooks.Rows[i].Cells[0].Value.ToString() + "'", con);
                                        cmd.ExecuteNonQuery();
                                        if (i == dgvRentbooks.RowCount)
                                        {
                                            cmd = new SqlCommand("Delete From  tbReserve_Detail Where rsid='" + rsid + "'", con);
                                            cmd.ExecuteNonQuery();
                                        }
                                    }
                                }
                            }
                        }
                    }
                    MyMessageBox.ShowMesage("ບັນທືກການຢືມສຳເສັດແລ້ວ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvRentbooks.Rows.Clear();
                    ClearData();
                    Reserve = false;
                    rsid = "";
                    MaxID();
                }
            }catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກການຢືມບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearData()
        {
            indx = -1;
            txtbarcode.Clear();
            if (dgvRentbooks.RowCount <1)
            {
                lbMemberID.Text = "";
                lbMemberName.Text = "";
                txtmemberid.Clear();
                lbTel.Text = "";

                btsave.Enabled = false;
                txtbarcode.Enabled = false;
                txtmemberid.Focus();
            }
        }

        //Barcode Reader
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            char c = (char)keyData;
            myBarcode += c;
            if (c == (char)Keys.Return)
            {
                //MessageBox.Show(myBarcode);
                AddDataToDgv(myBarcode);
                myBarcode = "";


            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void frmRentBook_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            dateST.Value = DateTime.Now;
            txtbarcode.Enabled = false;
            btsave.Enabled = false;
            MaxID();
            LoadMemberID();
            LoadBookID();
            dateST.Value = DateTime.Now;
            if (listVal != null)
            {
                AddData();
            }
        }

        private void txtbid_TextChanged(object sender, EventArgs e)
        {
            // bid = txtbid.Text;
            MessageBox.Show(dgvRentbooks.RowCount.ToString());
            if (dgvRentbooks.RowCount < 3)
            {
                AddDataToDgv(txtbarcode.Text);
            }
            else
            {
                MyMessageBox.ShowMesage("ຢືມໄດ້ຫຼາຍສຸດ 3 ຫົວ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //txtbid.Focus();
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
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

        private void groupBox2_MouseCaptureChanged(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void txtRentId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Swicth_Language(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void txtmemberid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtmemberid.Text!="")
            {
                txtbarcode.Focus();
            }
        }

        private void dateST_ValueChanged(object sender, EventArgs e)
        {
            CancalarData();
        }

        private void txtmemberid_TextChanged_1(object sender, EventArgs e)
        {
            if (txtmemberid.Text != "")
            {
                FillData_ToLable();
                if (txtmemberid.Text != "" && lbMemberName.Text != "" && lbTel.Text != "")
                {
                    if (ExpireMember.CompareTo(DateTime.Now) == 1)
                    {
                        //Check Data
                        Check_MemberRent();
                    }
                    else
                    {
                        MyMessageBox.ShowMesage("ບັດນີ້ໝົດອາຍຸແລ້ວ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btsave.Enabled = false;
                    }
                }
            }
            else
            {
                ClearData();
            }
        }

        private void dgvRentbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _home.Clear_PanelMenu();
            if (e.ColumnIndex == 9)
            {
                if (indx > (-1))
                {
                    if (dgvRentbooks.Rows.Count > 0)
                    {
                        if (Reserve == true)
                        {
                            cmd = new SqlCommand("Delete From  tbReserve Where barcode='" + dgvRentbooks.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                            cmd.ExecuteNonQuery();
                            cmd = new SqlCommand("Update tbBooks Set status=N'ຫວ່າງ' Where barcode='" + dgvRentbooks.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                            if (cmd.ExecuteNonQuery() == 1)
                            {
                                cmd = new SqlCommand("Select bid From tbBooks Where barcode='" + dgvRentbooks.Rows[e.RowIndex].Cells[0].Value.ToString() + "'", con);
                                da = new SqlDataAdapter(cmd);
                                table = new DataTable();
                                table.Clear();
                                da.Fill(table);

                                if (table.Rows.Count > 0)
                                {
                                    cmd = new SqlCommand("Update tbBooks_Detail Set reserQty-=1 Where bid='" + table.Rows[0][0].ToString() + "'", con);
                                    if (cmd.ExecuteNonQuery() == 1)
                                    {
                                        cmd = new SqlCommand("Update tbReserve_Detail Set qty-=1 Where rsid='" + rsid + "'", con);
                                        cmd.ExecuteNonQuery();
                                    }
                                }
                            }
                        }
                        dgvRentbooks.Rows.RemoveAt(indx);
                    }
                        ClearData();
                }
            }
        }

        private void NextControl(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    SelectNextControl((Control)sender, true, true, true, true);
            //}
        }
        private void dgvReserbooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indx = e.RowIndex;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            Save();
            txtmemberid.Focus();
        }
    }
}
