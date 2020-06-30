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
    public partial class frmDetpart : Form
    {
        public frmDetpart()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmDetpart(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds = new DataSet();
        DataTable table;
        frmEditDepart depart;

        private void Show_data()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvdepart.Rows.Clear();
                da = new SqlDataAdapter("Select * From tbDepart", con);
                da.Fill(table);
                for(int col=0; col < table.Rows.Count; col++)
                {
                    dgvdepart.Rows.Add(table.Rows[col][0].ToString(),table.Rows[col][1].ToString());
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } 
        private void ShearchData()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvdepart.Rows.Clear();
                da = new SqlDataAdapter("Select * From tbDepart Where depid like '"+txtSearch.Text+"%' Or name Like N'"+txtSearch.Text+"%'", con);
                da.Fill(table);
                for(int col=0; col < table.Rows.Count; col++)
                {
                    dgvdepart.Rows.Add(table.Rows[col][0].ToString(),table.Rows[col][1].ToString());
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Return 1 "Complete action" If Return 0 "Don't complete action"
        public int Save(string id, string name)
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbDepart Values(@id,@name)", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_data();
                    MyModel.fsh_action=1;
                }
                
            }
            catch (Exception ex)
            {
                MyModel.fsh_action = 0;
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MyModel.fsh_action;
        }
        public int Edit(string id, string name)
        {
            try
            {
                cmd = new SqlCommand("Update tbDepart Set name=@name Where depid=@id", con);
                cmd.Parameters.AddWithValue("id", id);
                cmd.Parameters.AddWithValue("name", name);
                cmd.ExecuteNonQuery();
                Show_data();
                MyModel.fsh_action = 1;
            }
            catch (Exception ex)
            {
                MyModel.fsh_action = 0;
                MyMessageBox.ShowMesage("ແກ້ໄຂບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MyModel.fsh_action;
        }
        private void Delete(string id)
        {
            try
            {
                DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກບໍ່?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete From tbDepart Where depid=@id", con);
                    cmd.Parameters.AddWithValue("id", id);
                    cmd.ExecuteNonQuery();
                    Show_data();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ລົບບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDetpart_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();
            ///
            Show_data();
        }
        
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void dgvdepart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                depart = new frmEditDepart(this);
                depart.id = dgvdepart.Rows[e.RowIndex].Cells[0].Value.ToString();
                depart.name = dgvdepart.Rows[e.RowIndex].Cells[1].Value.ToString();
                depart.edit = true; ;
                depart.ShowDialog();
            }
            else if(e.ColumnIndex==3)
            {
                Delete(dgvdepart.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            depart = new frmEditDepart(this);
            depart.ShowDialog();
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

        private void dgvdepart_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }
    }
}
