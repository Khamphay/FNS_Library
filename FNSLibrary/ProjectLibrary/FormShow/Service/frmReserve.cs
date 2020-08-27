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
using ProjectLibrary.MSDialog;

namespace ProjectLibrary
{
    public partial class frmReserve : Form
    {
        public frmReserve()
        {
            InitializeComponent();
            
        }

        // ຈຳລອງ Form Form1 ໃຫ້ຄືກັນກັບ frmReserve
        Form1 _home;
         public frmReserve(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable table;
        DataSet ds = new DataSet();
        AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
        string[] colname = { "ລະຫັດປື້ມ", "ຊື່ປື້ມ", "ISBN", "ຈຳນວນໜ້າ", "ຈຳນວນປື້ມ", "ໝວດ", "ປະເພດ","ລະຫັດຕູ້", "ຈ້ອງ" };
        int qty=0;
        string[] barc = new string[3];

        private void ShowType()
        {
            try
            {
                cmd = new SqlCommand(@"SELECT  tbBooks_Detail.bname as[bookName], tbCategory.[name] as [catgName], tbType.typename as [typeName] FROM  tbBooks INNER JOIN tbBooks_Detail ON tbBooks.bid = tbBooks_Detail.bid INNER JOIN tbCategory ON tbBooks_Detail.catgid = tbCategory.catgid INNER JOIN tbType ON tbBooks_Detail.typeid = tbType.typeid Where tbBooks.[status]='ຫວ່າງ'",con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.Add(dr["bookName"].ToString());
                    auto.Add(dr["catgName"].ToString());
                    auto.Add(dr["typeName"].ToString());
                }
                txtSearch.AutoCompleteCustomSource = auto;
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
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
        private void Show_Data()
        {
            try
            {
                dgvbooks.Rows.Clear();
                da = new SqlDataAdapter(@"Select tbBooks_Detail.bid, tbBooks_Detail.bname, tbBooks_Detail.[page], tbBooks_Detail.Qty, tbBooks_Detail.ISBN, tbCategory.[name], tbType.typename, tbBooks_Detail.tbdid from tbBooks_Detail Inner Join tbCategory On tbBooks_Detail.catgid=tbCategory.catgid Inner Join tbType On tbBooks_Detail.typeid=tbType.typeid", con);
                table = new DataTable();
                table.Clear();
                da.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    dgvbooks.Rows.Add(
                        table.Rows[i][0].ToString(),
                        table.Rows[i][1].ToString(),
                        table.Rows[i][2].ToString(),
                        table.Rows[i][3].ToString(),
                        table.Rows[i][4].ToString(),
                        table.Rows[i][5].ToString(),
                        table.Rows[i][6].ToString(),
                        table.Rows[i][7].ToString(),
                        false
                        );
                }
                dgvbooks.Refresh();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Shearch()
        {
            try
            {
                dgvbooks.Rows.Clear();
                da = new SqlDataAdapter(@"Select tbBooks_Detail.bid, tbBooks_Detail.bname, tbBooks_Detail.[page], tbBooks_Detail.Qty, tbBooks_Detail.ISBN, tbCategory.[name], tbType.typename, tbBooks_Detail.tbdid from tbBooks_Detail Inner Join tbCategory On tbBooks_Detail.catgid=tbCategory.catgid Inner Join tbType On tbBooks_Detail.typeid=tbType.typeid Where  tbBooks_Detail.bid Like '" + txtSearch.Text + "%' OR tbBooks_Detail.bname Like N'" + txtSearch.Text + "%' OR tbCategory.[name] Like N'" + txtSearch.Text + "%' OR tbType.typename Like N'" + txtSearch.Text + "%'", con);
                table = new DataTable();
                table.Clear();
                da.Fill(table);
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        dgvbooks.Rows.Add(
                            table.Rows[i][0].ToString(),
                            table.Rows[i][1].ToString(),
                            table.Rows[i][2].ToString(),
                            table.Rows[i][3].ToString(),
                            table.Rows[i][4].ToString(),
                            table.Rows[i][5].ToString(),
                            table.Rows[i][6].ToString(),
                            table.Rows[i][7].ToString(),
                            false
                            );
                    }
                dgvbooks.Refresh();
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddData() {
            List<Reservation_DataList> list = new List<Reservation_DataList>();

            //Use for the columns than checked
            foreach (DataGridViewRow row in dgvbooks.Rows)
            {
                if (row.Cells[8].Value != null)
                {
                    if ((Boolean)row.Cells[8].Value == true)
                    {

                        //Select Barcode from tbBooks for Random
                        table = new DataTable();
                        table.Clear();
                        da = new SqlDataAdapter("Select barcode From tbBooks Where status=N'ຫວ່າງ' And bid='" + row.Cells[0].Value.ToString() + "'",con);
                        da.Fill(table);

                        //Random Barcode From table
                        Random rd = new Random();
                        int rowindex = rd.Next(0, table.Rows.Count);

                        list.Add(new Reservation_DataList
                        {
                            getID = table.Rows[rowindex][0].ToString(),
                            getName = row.Cells[1].Value.ToString(),
                            getPage = int.Parse(row.Cells[2].Value.ToString()),
                            getQty = 1,
                            getCategory = row.Cells[5].Value.ToString(),
                            getType = row.Cells[6].Value.ToString(),
                            getTableID = row.Cells[7].Value.ToString(),
                            
                        });
                    }
                }
            }

            frmReservation reservation = new frmReservation();
            reservation.val = list; //val virible in form 'frmReservation'
            reservation.ShowDialog();
            // If Form  frmReservation is close
            if (reservation.Visible == false && reservation.comflim==true)
            {
                barc[0] = null;
                barc[1] = null;
                barc[2] = null;
                lbqty.Text = "0";
                Show_Data();
            }
        }
        private void frmReserve_Load(object sender, EventArgs e)
        {
            barc[0] = null;
            barc[1] = null;
            barc[2] = null;
           
            btsave.Enabled = false;
            ShowType();
            Show_Data();
            _home.DateleifExpireReservetion();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            AddData();
        }

        private void dgvbooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 8)
            {
                if (dgvbooks.Rows[e.RowIndex].Cells[8].Value != null)
                {
                    if ((Boolean)dgvbooks.Rows[e.RowIndex].Cells[8].Value == true)
                    {
                        //dgvbooks.Columns[9].ReadOnly = false;
                        dgvbooks.Rows[e.RowIndex].Cells[8].Value = false;
                        qty = int.Parse(lbqty.Text) - 1;
                        lbqty.Text = qty.ToString();
                        if (qty <= 0)
                        {
                            btsave.Enabled = false;
                        }
                        for(int a = 0; a < barc.Length; a++)
                        {
                            
                            if (barc[a]== dgvbooks.Rows[e.RowIndex].Cells[0].Value.ToString())
                            {
                                barc[a] = null;
                            }
                        }
                    }
                    else
                    {
                        if (int.Parse(lbqty.Text) < 3)
                        {
                            dgvbooks.Rows[e.RowIndex].Cells[8].Value = true;
                            qty = int.Parse(lbqty.Text) + 1;
                            lbqty.Text = qty.ToString();
                            btsave.Enabled = true;

                            if (barc[0] == null)
                            {
                                barc[0] = dgvbooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                            }
                            else if (barc[1] == null)
                            {
                                barc[1] = dgvbooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                            }
                            else if (barc[2] == null)
                            {
                                barc[2] = dgvbooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                            }
                        }
                        else
                        {
                            dgvbooks.Columns[8].ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            if (txtSearch.Text != "")
            {
                Shearch();
            }
            else
            {
                Show_Data();
            }

            for (int i = 0; i < dgvbooks.RowCount; i++)
            {
                if (dgvbooks.Rows[i].Cells[0].Value.ToString() == barc[0])
                {
                    dgvbooks.Rows[i].Cells[8].Value = true;
                }
                if (dgvbooks.Rows[i].Cells[0].Value.ToString() == barc[1])
                {
                    dgvbooks.Rows[i].Cells[8].Value = true;
                }
                if (dgvbooks.Rows[i].Cells[0].Value.ToString() == barc[2])
                {
                    dgvbooks.Rows[i].Cells[8].Value = true;
                }
            }
        }

        private void btReserveInfo_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            frmReserveInfor info = new frmReserveInfor(_home);
            info.ShowDialog();
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
    }
}
