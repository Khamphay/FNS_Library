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
using Guna.UI;

namespace ProjectLibrary
{
    public partial class frmAuthor : Form
    {
        public frmAuthor()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmAuthor(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable table;
        AutoCompleteStringCollection auto;
        frmEditAuthor author;

        string[] colname = { "ລະຫັດ", "ຊື່ຜູ້ແຕ່ງ", "ນາມສະກຸນ", "ເບີໂທ" };

        private void Show_Data()
        {
            try
            {
                //#1
                //ds.Clear();
                da = new SqlDataAdapter("Select * From tbAthor", con);
                //da.Fill(ds, "ath");
                //dgvAuthor.DataSource = ds.Tables["ath"];
                //dgvAuthor.Refresh();
                //dgvAuthor.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //for (int i = 0; i < colname.Length; i++)
                //{
                //    dgvAuthor.Columns[i].HeaderText = colname[i];
                //}

                //#2
                table = new DataTable();
                table.Clear();
                dgvAuthor.Rows.Clear();
                da.Fill(table);
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvAuthor.Rows.Add(
                        table.Rows[col][0].ToString(),
                        table.Rows[col][1].ToString(),
                        table.Rows[col][2].ToString(),
                        table.Rows[col][3].ToString()
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShearchData()
        {
            try
            { 
                da = new SqlDataAdapter("Select * From tbAthor Where athid Like '"+txtSearch.Text+ "%' Or fname Like N'" + txtSearch.Text + "%' Or lname Like N'" + txtSearch.Text + "%' Or tel Like '" + txtSearch.Text + "%'", con);
                table = new DataTable();
                table.Clear();
                dgvAuthor.Rows.Clear();
                da.Fill(table);
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvAuthor.Rows.Add(
                        table.Rows[col][0].ToString(),
                        table.Rows[col][1].ToString(),
                        table.Rows[col][2].ToString(),
                        table.Rows[col][3].ToString()
                        );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Save(string id, string fname, string lname, string tel)
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbAthor Values(@id, @fname, @lname, @tel)", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("fname", fname);
                cmd.Parameters.AddWithValue("lname", lname);
                cmd.Parameters.AddWithValue("tel", tel);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Edit(string id, string fname, string lname, string tel)
        {
            try
            {
                cmd = new SqlCommand("Update tbAthor Set fname=@fname, lname=@lname, tel=@tel Where athid=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("fname", fname);
                cmd.Parameters.AddWithValue("lname", lname);
                cmd.Parameters.AddWithValue("tel", tel);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete(string id)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Are your sure ?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete From tbAthor Where athid=@id", con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    Show_Data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
       
        private void frmAuthor_Load(object sender, EventArgs e)
        {
            Show_Data();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //_home.ShowHomePage();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            if (txtSearch.Text != "")
            {
                ShearchData();
            }
            else
            {
                Show_Data();
            }
        }

        private void dgvAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==4 ||e.ColumnIndex==5)
            {
                //DataGridViewCellStyle cellStyle = new DataGridViewCellStyle();
                //if (dgvAuthor.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.FromArgb(0, 118, 206))
                //{
                //    cellStyle.BackColor = Color.FromArgb(255, 255, 255);
                //    dgvAuthor.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cellStyle;
                //}
                //else
                //{
                //    cellStyle.BackColor = Color.FromArgb(0, 118, 206);
                //    dgvAuthor.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = cellStyle;
                //}
            }
            
            if (e.ColumnIndex == 4)
            {
                author = new frmEditAuthor(this);
                if (e.RowIndex >= 0)
                {
                    author.data[0] = dgvAuthor.Rows[e.RowIndex].Cells[0].Value.ToString();
                    author.data[1] = dgvAuthor.Rows[e.RowIndex].Cells[1].Value.ToString();
                    author.data[2] = dgvAuthor.Rows[e.RowIndex].Cells[2].Value.ToString();
                    author.data[3] = dgvAuthor.Rows[e.RowIndex].Cells[3].Value.ToString();
                    author.edit = true;
                }
                author.ShowDialog();
            }
            else if (e.ColumnIndex == 5)
            {
                Delete(dgvAuthor.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void dgvAuthor_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            author = new frmEditAuthor(this);
            author.ShowDialog();
        }

        private void dgvAuthor_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            //_ = dgvAuthor.Rows[e.RowIndex].DefaultCellStyle.BackColor=Color.Red;
            
        }
    }
}
