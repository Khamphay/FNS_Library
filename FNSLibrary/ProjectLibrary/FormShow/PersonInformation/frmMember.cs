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
    public partial class frmMember : Form
    {
        public frmMember()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmMember(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable table;
        DateTime dateEx;

        string[] colname = { "ລະຫັດ", "ຊື່ສະມາຊິກ", "ນາມສະກຸນ", "ເພດ", "ເບີໂທລະສັບ", "ບ້ານ", "ເມືອງ", "ແຂວງ", "ວ.ດ.ປ ເກີດ", "ພາກວິຊາ", "ວັນທີລົງທະບຽນ", "ວັນທີໝົດອາຍຸ" };

        string[] data=new string[12];

        private void SetBackColor_DataGrid(DateTime date,DateTime dateEnd, int row, string status)
        {
            if (status == "ບັດເສຍ")
            {
                dgvMember.Rows[row].DefaultCellStyle.ForeColor = Color.Red;
            }
            if (DateTime.Now.CompareTo(dateEnd) > 0)
            {
                dgvMember.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(248, 153, 146);
            }
            else if (DateTime.Now.CompareTo(date) > 0)
            {
                dgvMember.Rows[row].DefaultCellStyle.BackColor = Color.FromArgb(249, 207, 156);
            } 
            else
            {
                dgvMember.Rows[row].DefaultCellStyle.BackColor = Color.White;
            }
        }
        private void Shearch_Data()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvMember.Rows.Clear();
                ds.Clear();
                cmd = new SqlCommand("Select * From tbMember Where mid Like '" + txtSearch.Text+"%' Or fname Like N'"+txtSearch.Text+"%' Or lname Like N'"+txtSearch.Text+"%' Or gender Like N'"+txtSearch.Text+ "%' Or tel Like '"+txtSearch.Text+ "%' Or village Like N'" + txtSearch.Text+ "%' Or district Like N'" + txtSearch.Text+ "%'Or province Like N'" + txtSearch.Text+ "%' Or detpname Like N'" + txtSearch.Text+ "%'", con);
                da = new SqlDataAdapter(cmd);
                da.Fill(table);
                //#1
                for (int row = 0; row < table.Rows.Count; row++)
                {
                    dgvMember.Rows.Add(
                        table.Rows[row][0].ToString(),
                        table.Rows[row][1].ToString(),
                        table.Rows[row][2].ToString(),
                        table.Rows[row][3].ToString(),
                        table.Rows[row][4].ToString(),
                        table.Rows[row][5].ToString(),
                        table.Rows[row][6].ToString(),
                        table.Rows[row][7].ToString(),
                        DateTime.Parse(table.Rows[row][8].ToString()).ToString("dd-MM-yyyy"),
                        table.Rows[row][9].ToString(),
                       DateTime.Parse(table.Rows[row][10].ToString()).ToString("dd-MM-yyyy"),
                       DateTime.Parse(table.Rows[row][11].ToString()).ToString("dd-MM-yyyy")
                        );
                    dateEx = DateTime.Parse(table.Rows[row][11].ToString());
                    SetBackColor_DataGrid(dateEx, DateTime.Parse(table.Rows[row][12].ToString()), row, table.Rows[row][13].ToString());

                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Show_Data()
        {
            try
            {
                table = new DataTable();
                dgvMember.Rows.Clear();
                ds.Clear();
                cmd = new SqlCommand("Select * From tbMember", con);
                da = new SqlDataAdapter(cmd);
                da.Fill(table);
                //#1
                for(int row=0; row < table.Rows.Count; row++)
                {
                    dgvMember.Rows.Add(
                        table.Rows[row][0].ToString(),
                        table.Rows[row][1].ToString(),
                        table.Rows[row][2].ToString(),
                        table.Rows[row][3].ToString(),
                        table.Rows[row][4].ToString(),
                        table.Rows[row][5].ToString(),
                        table.Rows[row][6].ToString(),
                        table.Rows[row][7].ToString(),
                        DateTime.Parse(table.Rows[row][8].ToString()).ToString("dd-MM-yyyy"),
                        table.Rows[row][9].ToString(),
                       DateTime.Parse(table.Rows[row][10].ToString()).ToString("dd-MM-yyyy"),
                       DateTime.Parse(table.Rows[row][11].ToString()).ToString("dd-MM-yyyy")
                        );
                    dateEx = DateTime.Parse(table.Rows[row][11].ToString());
                    SetBackColor_DataGrid(dateEx, DateTime.Parse(table.Rows[row][12].ToString()), row, table.Rows[row][13].ToString());
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShowFormEdit(int idx)
        {
            //Fill Data to valible data[]
            if (idx >= 0)
            {
                for (int i = 0; i < dgvMember.ColumnCount - 2; i++)
                {
                    data[i] = dgvMember.Rows[idx].Cells[i].Value.ToString();
                }
                //Open Edit page
                frmRegister rigister = new frmRegister(data);
                rigister.status = true;
                rigister.ShowDialog();
                if (rigister.Visible == false)
                {
                    Show_Data();
                    for (int i = 0; i < data.Length; i++)
                    {
                        data[i] = "";
                    }
                }
            }
        }
        private void frmMember_Load(object sender, EventArgs e)
        {
            Show_Data();
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            
        }

        private void gunaGroupBox1_Click_1(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void dgvMember_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _home.Clear_PanelMenu();

            if (e.ColumnIndex == 12)
            {
                ShowFormEdit(e.RowIndex);
            }
            else if (e.ColumnIndex == 13)
            {
                try
                {
                    DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກບໍ່?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Delete From tbMember Where mid=@id", con);
                        cmd.Parameters.AddWithValue("id", dgvMember.Rows[e.RowIndex].Cells[0].Value.ToString());
                        cmd.ExecuteNonQuery();
                        Show_Data();
                    }
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMesage("ລົບບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
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

        private void dgvMember_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ShowFormEdit(e.RowIndex);
        }
    }
}
