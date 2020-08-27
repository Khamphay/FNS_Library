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
    public partial class frmReservation : Form
    {
        public frmReservation()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable table;
        string maxid = "", expid="";
        int newid = 0, qty=0, indx=-1;
        public bool comflim = false;
        DateTime dateNow;
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();

        bool mouse = false;
        int mouX = 0, mouY = 0;

        public List<Reservation_DataList> val;
        
        public void ShowData()
        {
            if (val != null)
            {
                foreach (Reservation_DataList list in val)
                {
                    int i = dgvReserbooks.Rows.Add();

                    dgvReserbooks.Rows[i].Cells[0].Value = list.getID;
                    dgvReserbooks.Rows[i].Cells[1].Value = list.getName;
                    dgvReserbooks.Rows[i].Cells[2].Value = list.getPage;
                    dgvReserbooks.Rows[i].Cells[3].Value = list.getQty;
                    dgvReserbooks.Rows[i].Cells[4].Value = list.getCategory;
                    dgvReserbooks.Rows[i].Cells[5].Value = list.getType;
                    dgvReserbooks.Rows[i].Cells[6].Value = list.getTableID;
                }
            }
        }
        private void Delete()
        {
            try
            {
                //cmd = new SqlCommand("Select rsid, dateEd From tbReserve_Detail",con);
                //dr = cmd.ExecuteReader();
                //while (dr.Read())
                //{
                //    dateExpire = DateTime.Parse(dr["dateEd"].ToString());
                //    if (DateTime.Compare(dateNow, dateExpire) == 0)
                //    {
                //        cmd = new SqlCommand("Delete From tbReserve_Detail Where rsid='"+dr["rsid"].ToString() +"'",con);
                //        cmd.ExecuteNonQuery();
                //    }
                //}
            }catch (Exception ex)
            {
                MessageBox.Show("Error compare date: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                //dr.Close();
            }
        }
        private void MaxID()
        {
            char[] cid;
            int index = 0;
            try
            {
                cmd = new SqlCommand("Select MAX(rsid) as [MaxID] From tbReserve_Detail", con);
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
                    newid = int.Parse(dr["MaxID"].ToString().Substring(index)) + 1;
                    if (newid < 10)
                    {
                        txtRentId.Text = $"{maxid}00{newid}";
                    }
                    else if(newid>=10 || newid<100)
                    {
                        txtRentId.Text = $"{maxid}0{newid}";
                    }
                    else
                    {
                        txtRentId.Text = $"{maxid}{newid}";
                    }
                }
                else
                {
                    //txtRentId.Enabled = true;
                    txtRentId.Text = "Rs001";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load max id data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (txtmemberid.Text != "")
                {
                    cmd = new SqlCommand("Insert Into tbReserve_Detail Values(@id, @mid, @datest, @dated, @qty)", con);
                    cmd.Parameters.AddWithValue("id", txtRentId.Text);
                    cmd.Parameters.AddWithValue("mid", txtmemberid.Text);
                    cmd.Parameters.AddWithValue("datest", SqlDbType.DateTime).Value = dateST.Value;
                    cmd.Parameters.AddWithValue("dated", SqlDbType.DateTime).Value = dateED.Value;
                    cmd.Parameters.AddWithValue("qty", SqlDbType.Int).Value = dgvReserbooks.RowCount;
                    cmd.ExecuteNonQuery();

                    for (int i = 0; i < dgvReserbooks.RowCount; i++)
                    {
                        cmd = new SqlCommand("Insert Into tbReserve Values(@rsid, @bid, @qty)", con);
                        cmd.Parameters.AddWithValue("rsid", txtRentId.Text);
                        cmd.Parameters.AddWithValue("bid", dgvReserbooks.Rows[i].Cells[0].Value.ToString());
                        cmd.Parameters.AddWithValue("qty", dgvReserbooks.Rows[i].Cells[3].Value.ToString());
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            cmd = new SqlCommand("Update tbBooks Set status=N'ກຳລັງຈອງ' Where barcode='" + dgvReserbooks.Rows[i].Cells[0].Value.ToString() + "'", con);
                            cmd.ExecuteNonQuery();

                            //int indx = 0;
                            string bid = "";
                            //char[] ch = dgvReserbooks.Rows[i].Cells[0].Value.ToString().ToCharArray();

                            da = new SqlDataAdapter("Select bid From tbBooks Where barcode='" + dgvReserbooks.Rows[i].Cells[0].Value.ToString() + "'", con);
                            table = new DataTable();
                            table.Clear();
                            da.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                bid = table.Rows[0][0].ToString();
                            }

                            //for (int J = 0; J < ch.Length; J++)
                            //{
                            //    if (char.IsLetter(ch[J]))
                            //    {
                            //        indx += 1;
                            //    }
                            //}
                            //bid = dgvReserbooks.Rows[i].Cells[0].Value.ToString().Substring(0, indx);

                            cmd = new SqlCommand("Update tbBooks_Detail Set reserQty+=" + int.Parse(dgvReserbooks.Rows[i].Cells[3].Value.ToString()) + " Where bid='" + bid + "'", con);
                            cmd.ExecuteNonQuery();
                            bid = "";
                            comflim = true;

                        }
                    }
                    dgvReserbooks.Rows.Clear();
                    MyMessageBox.ShowMesage("ບັນທືກການຈອງສຳເສັດແລ້ວ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MaxID();
                    this.Close();
                }
                else
                {
                    MyMessageBox.ShowMesage("ກະລຸນາກວດສອບຂໍ້ມູນສະມາຊິກຂອງທ່ານ ແລ້ວລອງໃຫມ່ອີກຄັ້ງ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmReservation_Load(object sender, EventArgs e)
        {
            Delete();
            LoadMemberID();
            MaxID();
            ShowData();
            dateST.Value = DateTime.Now;
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
            if (e.RowIndex >= 0 && e.ColumnIndex==7)
            {
                dgvReserbooks.Rows.RemoveAt(e.RowIndex);
                if (dgvReserbooks.RowCount == qty && qty>0)
                {
                    btsave.Enabled = true;
                }
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        { 
            Save();
        }

        private void EanableKey(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dateST_ValueChanged(object sender, EventArgs e)
        {
            int day = 1;
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
                for (int i = 1; i <= day; i++)
                {
                    dateNow = DateTime.Now.AddDays(i);
                    if (dateNow.DayOfWeek.ToString() == "Saturday" || dateNow.DayOfWeek.ToString() == "Sunday")
                    {
                        day += 1;
                    }
                }
            }

            dateNow = dateST.Value;
            dateED.Value = dateNow.AddDays(day);
            //    }
            //    else
            //    {
            //        //MessageBox.Show("Please select day of to date", "Warning");
            //        dateST.Value = DateTime.Now;
            //    }
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
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

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }

        private void txtmemberid_TextChanged(object sender, EventArgs e)
        {
            if (txtmemberid.Text != "")
            {
                try
                {
                    cmd = new SqlCommand("Select fname, lname, tel From tbMember Where mid='" + txtmemberid.Text + "' And dateREd>@dateEd And dateCardEnd>@date And status!=N'ບັດເສຍ'", con);
                    cmd.Parameters.AddWithValue("dateEd", DbType.Date).Value = DateTime.Now;
                    cmd.Parameters.AddWithValue("date", DbType.Date).Value = DateTime.Now;
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        txtfname.Text = dr["fname"].ToString();
                        txtlname.Text = dr["lname"].ToString();
                        txtTel.Text = dr["tel"].ToString();
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

                try
                {
                    cmd = new SqlCommand("Select mid, Sum(qty) as qty From tbReserve_Detail Where mid='" + txtmemberid.Text + "' Group By mid", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        if (dr.GetInt32(1) < 3)
                        {
                            qty = 3 - dr.GetInt32(1);

                            if ((dr.GetInt32(1) + dgvReserbooks.RowCount) > 3)
                            {
                                MyMessageBox.ShowMesage($"ທ່ານສາມາດຈອງໄດ້ປຶ້ມ {3 - dr.GetInt32(1)} ຫົວ ເນື່ອງຈາກໄດ້ຈອງກ່ອນໜ້ານີ້ {dr.GetInt32(1)} ຫົວແລ້ວ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                btsave.Enabled = false;
                            }
                        }
                        else
                        {
                            MyMessageBox.ShowMesage("ບໍ່ສາມາດຈອງໄດ້ເນື່ອງຈາກທ່ານໄດ້ຈອງກ່ອນໜ້ານີ້ແລ້ວ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btsave.Enabled = false;
                        }
                    }
                    else
                    {
                        btsave.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການກວດສອບຂໍ້ມູນການຈອງ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dr.Close();
                }
            }
            else
            {
                txtfname.Clear();
                txtlname.Clear();
                txtTel.Clear();
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {

        }

        private void txtTel_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Save();
            }
        }
      
    }
}
