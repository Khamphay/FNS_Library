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
    public partial class frmBooks : Form
    {
        public frmBooks()
        {
            InitializeComponent();
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable table;
        DataSet ds = new DataSet();
        AutoCompleteStringCollection auto;
        string[] colname = { "ລະຫັດບາໂຄດ", "ຊື່ປື້ມ", "ຈຳນວນ", "ລະຫັດຕູ້", "ຊື່ຜູ້ແຕ່ງ" };
        string atid = "";

        private void Load_Author()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select fname From tbAthor", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbAuthor.Items.Add(dr["fname"].ToString());
                    auto.Add(dr["fname"].ToString());
                }
                cmbAuthor.AutoCompleteCustomSource = auto;
                cmbAuthor.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbAuthor.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }catch (Exception ex)
            {
                MessageBox.Show("Error load author data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void Load_Table()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select tbdid From tbTable", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbTable.Items.Add(dr["tbdid"].ToString());
                    auto.Add(dr["tbdid"].ToString());
                }
                cmbTable.AutoCompleteCustomSource = auto;
                cmbTable.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbTable.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load table data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                ds.Clear();
                da = new SqlDataAdapter("vw_Book", con);
                da.Fill(ds, "book");                                    
                dgvbooks.DataSource = ds.Tables["book"];
                dgvbooks.Refresh();
                dgvbooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                for (int i = 0; i < colname.Length; i++)
                {
                    dgvbooks.Columns[i].HeaderText = colname[i];
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbBooks(bgid, athid) Values(@id, @athid)", con);
                cmd.Parameters.AddWithValue("id", txtid.Text);
                cmd.Parameters.AddWithValue("athid", atid);
                if (cmd.ExecuteNonQuery() == 1)                                              
                {
                    Show_Data();
                    Clear_data();
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                cmd = new SqlCommand("Update tbBooks Set athid=@athid Where bgid=@id", con);
                cmd.Parameters.AddWithValue("id", txtid.Text);
                cmd.Parameters.AddWithValue("athid", atid);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                    Clear_data();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error editing data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Delete()
        {
            try
            {
                cmd = new SqlCommand("Delete From tbBooks Where bgid='"+txtid.Text+"'", con);
                cmd.ExecuteNonQuery();
                Show_Data();
                Clear_data();
            }catch(Exception ex)
            {
                MessageBox.Show("Error delete data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Clear_data()
        {
            txtid.Clear();
            txtid.Enabled = true;
            txtname.Clear();
            cmbAuthor.SelectedIndex = -1;
            cmbTable.SelectedIndex = -1;
        }

        private void frmBooks_Load(object sender, EventArgs e)
        {
            Load_Author();
            Load_Table();
            Show_Data();
        }
        private void cmdAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select athid From tbAthor Where fname='" + cmbAuthor.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    atid = dr["athid"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error select data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
            
            
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btedit_Click(object sender, EventArgs e)
        {
            Edit();
            txtid.Enabled = true;
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Are you sure?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (dialog == DialogResult.Yes)
            {
                Delete();
            }
        }

        private void dgvbooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                txtid.Text = dgvbooks.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtname.Text = dgvbooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                cmbTable.Text = dgvbooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                cmbAuthor.Text = dgvbooks.Rows[e.RowIndex].Cells[4].Value.ToString();

                txtid.Enabled = false;
            }
        }
    }
}
