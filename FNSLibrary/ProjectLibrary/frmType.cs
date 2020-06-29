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
    public partial class frmType : Form
    {
        public frmType()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmType(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }
        


        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable table;
        frmEditType type;

        int index = -1;
        private void Show_data()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvtype.Rows.Clear();
                da = new SqlDataAdapter("Select * From tbType", con);
                da.Fill(table);
                for(int col=0;col< table.Rows.Count; col++)
                {
                    dgvtype.Rows.Add(table.Rows[col][0].ToString(), table.Rows[col][1].ToString());
                }
                //dgvtype.Columns[0].HeaderText = "ລະຫັດປະເພດປື້ມ";
                //dgvtype.Columns[1].HeaderText = "ຊື່ປະເພດປື້ມ";

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
                table = new DataTable();
                table.Clear();
                dgvtype.Rows.Clear();
                da = new SqlDataAdapter("Select * From tbType Where typeid Like '"+txtSearch.Text+"%' Or typename Like N'"+txtSearch.Text+"%'", con);
                da.Fill(table);
                for(int col=0;col< table.Rows.Count; col++)
                {
                    dgvtype.Rows.Add(table.Rows[col][0].ToString(), table.Rows[col][1].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Return 1 "Complete action" If Return 0 "Don't complete action"
        public int Save(string id, string name)
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbType Values(@id,@name)", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_data();
                    MyModel.fsh_action = 1;
                }               
            }
            catch (Exception ex)
            {
                MyModel.fsh_action = 0;
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MyModel.fsh_action;
        }
        public int Edit(string id, string name)
        {
            try
            {
                cmd = new SqlCommand("Update tbType Set typename=@name Where typeid=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
               if(cmd.ExecuteNonQuery() == 1)
                {
                    Show_data();
                    MyModel.fsh_action = 1;
                }                
            }
            catch (Exception ex)
            {
                MyModel.fsh_action = 0;
                MessageBox.Show("Error editing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MyModel.fsh_action;
        }
        private void Delete(string id)
        {
            try
            {
                cmd = new SqlCommand("Delete From tbType Where typeid=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.ExecuteNonQuery();
                Show_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmType_Load(object sender, EventArgs e) { 
            Show_data();
        }
       
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void dgvtype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                type = new frmEditType(this);
                type.tid = dgvtype.Rows[e.RowIndex].Cells[0].Value.ToString();
                type.tname = dgvtype.Rows[e.RowIndex].Cells[1].Value.ToString();
                type.edit = true;

                type.ShowDialog();
            }
            else if (e.ColumnIndex == 3)
            {
                DialogResult dialog = MessageBox.Show("Are you sure to delete ?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    Delete(dgvtype.Rows[e.RowIndex].Cells[0].Value.ToString());
                }
            }
        }


        private void btsave_Click_1(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            type = new frmEditType(this);
            type.ShowDialog();
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
                Show_data();
            }
        }

        private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }
    }
}
