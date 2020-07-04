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
    public partial class frmCost : Form
    {
        public frmCost()
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
                da = new SqlDataAdapter("Select cost From tbRegister_cost",con);
                da.Fill(table);
                if (table.Rows.Count>0 && Convert.ToDecimal(table.Rows[0][0]) > 0) 
                { 
                    lbCost.Text = "ຄ່າລົງທະບຽນ: "+ double.Parse(table.Rows[0][0].ToString()).ToString("#,###.#0") + " ກີບ";
                }
            }catch(Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                cmd = new SqlCommand("Insert Into tbRegister_cost(cost) Values("+txtcost.Text+")", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                }
            }catch(Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                cmd = new SqlCommand("Update tbRegister_cost Set cost=" + txtcost.Text, con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ແກ້ໄຂບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SaveAndEdit()
        {

            table = new DataTable();
            table.Clear();
            da = new SqlDataAdapter("Select cost From tbRegister_cost Where rgid=1", con);
            da.Fill(table);
            if (table.Rows.Count <= 0)
            {
                Save_Const();
            }
            else
            {
                Edit();
            }
            txtcost.Clear();
        }

        private void frmCost_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            Show_Data();
        }

        private void txtcost_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            SaveAndEdit();
        }

        private void txtcost_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveAndEdit();
            }
        }
    }
}
