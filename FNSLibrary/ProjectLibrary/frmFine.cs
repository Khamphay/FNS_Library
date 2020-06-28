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
    public partial class frmFine : Form
    {
        public frmFine()
        {
            InitializeComponent();
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataTable table;

        private void Show_Data()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                da = new SqlDataAdapter("Select price From tbFine", con);
                da.Fill(table);
                if (table.Rows.Count > 0 && Convert.ToDecimal(table.Rows[0][0]) > 0)
                {
                    lbCost.Text = "ຄ່າປັບໃໝ: " + double.Parse(table.Rows[0][0].ToString()).ToString("#,###.#0") + " ກີບ/1 ໜ້າ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error show data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // dr.Close();
            }
        }
        private void Save_Const()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbFine(price) Values(" + txtPrice.Text + ")", con);
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
        private void Edit()
        {
            try
            {
                cmd = new SqlCommand("Update tbFine Set price=" + txtPrice.Text, con);
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

        private void frmFine_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            Show_Data();
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Clear();
            da = new SqlDataAdapter("Select price From tbFine Where fid=1", con);
            da.Fill(table);
            if (table.Rows.Count <= 0)
            {
                Save_Const();
            }
            else
            {
                Edit();
            }
            txtPrice.Clear();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }
    }
}
