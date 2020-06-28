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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

         Form1 _home;
         public frmCategory(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }



        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable table;

        frmEditCateg editctg;

        private void Show_data()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvcategory.Rows.Clear();
                da = new SqlDataAdapter("Select * From tbCategory", con);
                da.Fill(table);
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvcategory.Rows.Add(table.Rows[col][0].ToString(), table.Rows[col][1].ToString());
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error show data: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void ShearchData()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvcategory.Rows.Clear();
                da = new SqlDataAdapter("Select * From tbCategory Where catgid Like '"+txtSearch.Text+"%' Or name Like N'"+txtSearch.Text+"%'", con);
                da.Fill(table);
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvcategory.Rows.Add(table.Rows[col][0].ToString(), table.Rows[col][1].ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error show data: "+ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        public void Save(string id, string name)
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbCategory Values(@id,@name)", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.ExecuteNonQuery();
                Show_data();
            }catch(Exception ex)
            {
                MessageBox.Show("Error saving data: "+ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Edit(string id, string name)
        {
            try
            {
                cmd = new SqlCommand("Update tbCategory Set name=@name Where catgid=@id",con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.ExecuteNonQuery();
                Show_data();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error editing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete(string id)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("Are you sure to delete ?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete From tbCategory Where catgid=@id", con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    Show_data();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            Show_data();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void dgvcategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                editctg = new frmEditCateg(this);
                editctg.id = dgvcategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                editctg.name = dgvcategory.Rows[e.RowIndex].Cells[1].Value.ToString();
                editctg.edit = true;
                editctg.ShowDialog();
            }else if (e.ColumnIndex == 3)
            {
                Delete(dgvcategory.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            editctg = new frmEditCateg(this);
            editctg.ShowDialog();
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
