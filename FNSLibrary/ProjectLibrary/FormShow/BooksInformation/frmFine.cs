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

        bool mouse = false;
        int mouX = 0, mouY = 0;
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
                cmd = new SqlCommand("Insert Into tbFine(price) Values(" + txtPrice.Text + ")", con);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_Data();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MyMessageBox.ShowMesage("ແກ້ໄຂບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private void SaveAndEdit()
        {
            if (txtPrice.Text != "" && double.Parse(txtPrice.Text) > 0)
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
            else
            {
                MyMessageBox.ShowMesage("ກະລຸນາກວດສອບຂໍ້ມູນ ແລ້ວລອງໃໝ່ອີກຄັ້ງ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            SaveAndEdit();
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }

        private void txtPrice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveAndEdit();
            }
        }

        private void btMinimam_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouse == true)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouse = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouse = true;
            mouX = e.X;
            mouY = e.Y;
        }
    }
}
