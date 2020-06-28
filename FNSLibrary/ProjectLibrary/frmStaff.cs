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
    public partial class frmStaff : Form
    {
        public frmStaff()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmStaff(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        DataSet ds;
        DataTable table;
        frmEditStaff edstaff;

        string gender = "";
        string[] colname = { "ລະຫັດ", "ຊື່ພະນັກງານ", "ນາມສະກຸນ", "ເພດ", "ເບີໂທລະສັບ" };
        private void Show_Data()
        {
            try
            {
                //# 1
                //ds = new DataSet();
                //ds.Clear();
                da = new SqlDataAdapter("Select empid, fname, lname, gender, tel From tbStaff", con);
                //da.Fill(ds, "staff");
                //dgvStaff.DataSource = ds.Tables["staff"];
                //dgvStaff.Refresh();
                //dgvStaff.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                //for(int i = 0; i < colname.Length; i++)
                //{
                //    dgvStaff.Columns[i].HeaderText = colname[i];
                //}

                //# 2
                table = new DataTable();
                table.Clear();
                da.Fill(table);
                dgvStaff.Rows.Clear();
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvStaff.Rows.Add(
                        table.Rows[col][0].ToString(),
                        table.Rows[col][1].ToString(),
                        table.Rows[col][2].ToString(),
                        table.Rows[col][3].ToString(),
                        table.Rows[col][4].ToString()
                        );
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ShearchData()
        {
            try
            {
                da = new SqlDataAdapter("Select empid, fname, lname, gender, tel From tbStaff Where empid Like '"+txtSearch.Text+ "%' Or fname Like N'" + txtSearch.Text + "%' Or lname Like N'" + txtSearch.Text + "%' Or gender Like N'" + txtSearch.Text + "%' Or tel Like '" + txtSearch.Text + "%'", con);
                table = new DataTable();
                table.Clear();
                da.Fill(table);
                dgvStaff.Rows.Clear();
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvStaff.Rows.Add(
                        table.Rows[col][0].ToString(),
                        table.Rows[col][1].ToString(),
                        table.Rows[col][2].ToString(),
                        table.Rows[col][3].ToString(),
                        table.Rows[col][4].ToString()
                        );
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Save(string id, string name, string surename, string gen, string tel)
        {
            try
            {
                if (id != "" && name != "" && surename != "" && tel != "")
                {
                    cmd = new SqlCommand("Insert Into tbStaff(empid,fname,lname,gender,tel) Values(@id,@fname,@lname,@gender,@tel)", con);
                    cmd.Parameters.AddWithValue("id",id);
                    cmd.Parameters.AddWithValue("fname", name);
                    cmd.Parameters.AddWithValue("lname", surename);
                    cmd.Parameters.AddWithValue("gender", gen);
                    cmd.Parameters.AddWithValue("tel", tel);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Show_Data();
                    }
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Edit(string id, string name, string surename, string gen, string tel)
        {
            try
            {
                if (id != "" && name != "" && surename != "" && tel != "")
                {

                    cmd = new SqlCommand("Update tbStaff Set fname=@fname,lname=@lname,gender=@gender,tel=@tel Where empid=@id ", con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.Parameters.AddWithValue("fname", name);
                    cmd.Parameters.AddWithValue("lname", surename);
                    cmd.Parameters.AddWithValue("gender", gen);
                    cmd.Parameters.AddWithValue("tel", tel);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Show_Data();
                    }
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
                DialogResult dialog = MessageBox.Show("Are you sure to delete this reccord?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete From tbStaff Where empid=@id ", con);
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
        private void frmStaff_Load(object sender, EventArgs e)
        {
            Show_Data();
        }


        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void KeyNext(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }
        
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void dgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == 5)
            {
                edstaff = new frmEditStaff(this);
                if (e.RowIndex >= 0)
                {
                    edstaff.data[0] = dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString();
                    edstaff.data[1] = dgvStaff.Rows[e.RowIndex].Cells[1].Value.ToString();
                    edstaff.data[2] = dgvStaff.Rows[e.RowIndex].Cells[2].Value.ToString();
                    edstaff.data[3] = dgvStaff.Rows[e.RowIndex].Cells[3].Value.ToString();
                    edstaff.data[4] = dgvStaff.Rows[e.RowIndex].Cells[4].Value.ToString();
                }
                edstaff.edit = true;
                edstaff.ShowDialog();
            }
            else if(e.ColumnIndex==6)
            {
                Delete(dgvStaff.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            edstaff = new frmEditStaff(this);
            edstaff.ShowDialog();
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

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

    }
}
