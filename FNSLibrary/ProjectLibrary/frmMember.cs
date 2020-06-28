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

        private void SetBackColor_DataGrid(DateTime date, int row)
        {
            if (date.CompareTo(DateTime.Now) == 0)
            {
                dgvMember.Rows[row].DefaultCellStyle.BackColor = Color.Yellow;
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
                cmd = new SqlCommand("Select * From tbMember Where mid Like '"+ txtSearch.Text+"%' Or fname Like N'"+txtSearch.Text+"%' Or lname Like N'"+txtSearch.Text+"%' Or gender Like N'"+txtSearch.Text+ "%' Or tel Like '"+txtSearch.Text+ "%' Or village Like N'" + txtSearch.Text+ "%' Or district Like N'" + txtSearch.Text+ "%'Or province Like N'" + txtSearch.Text+ "%' Or detpname Like N'" + txtSearch.Text+ "%'", con);
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
                    SetBackColor_DataGrid(dateEx, row);

                }
            }
            catch (Exception ex)
            {

            }
        }
        private void Show_Data()
        {
            try
            {
                table = new DataTable();
                dgvMember.Rows.Clear();
                ds.Clear();
                cmd = new SqlCommand("Select * From tbMember",con);
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
                    SetBackColor_DataGrid(dateEx, row);
                }
                //#2
                //    da.Fill(ds, "member");
                //    dgvMember.DataSource = ds.Tables["member"];

                //    for (int i=0; i <colname.Length; i++)
                //    {
                //        dgvMember.Columns[i].HeaderText = colname[i];
                //    }
                //    dgvMember.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[10].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //    dgvMember.Columns[11].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            //Fill Data to valible data[]
                int index = e.RowIndex;
                if (index >= 0)
                {
                    for (int i = 0; i < dgvMember.ColumnCount - 2; i++)
                    {
                        data[i] = dgvMember.Rows[e.RowIndex].Cells[i].Value.ToString();
                    }
                }
            if (e.ColumnIndex == 12)
            {
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
            else if (e.ColumnIndex == 13)
            {
                try
                {
                    DialogResult dialog = MessageBox.Show("Are you sure to delete this reccord?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                    if (dialog == DialogResult.Yes)
                    {
                        cmd = new SqlCommand("Delete From tbMember Where mid=@id", con);
                        cmd.Parameters.AddWithValue("id", data[0]);
                        cmd.ExecuteNonQuery();
                        Show_Data();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error delete data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
