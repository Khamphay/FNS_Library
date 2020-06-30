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
    public partial class frmTable : Form
    {
        public frmTable()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmTable(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }


        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        SqlDataReader dr;
        DataSet ds = new DataSet();
        DataTable table ;
        frmEditTable tbtable;

        string[] id = new string[2];
        int qty = 0, subid = 0;
        string id2 = "", maxid = "";

        private void Show_data()
        {
            try
            {
                table = new DataTable();
                table.Clear();
                dgvtable.Rows.Clear();
                da = new SqlDataAdapter(@"select tbTableDetail.tbid, tbTable.tbdid from tbTable Inner Join tbTableDetail On tbTable.tbid = tbTableDetail.tbid; ", con);
                da.Fill(table);
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvtable.Rows.Add(table.Rows[col][0].ToString(), table.Rows[col][1].ToString());
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
                dgvtable.Rows.Clear();
                da = new SqlDataAdapter(@"select tbTableDetail.tbid, tbTable.tbdid from tbTable Inner Join tbTableDetail On tbTable.tbid = tbTableDetail.tbid Where tbTableDetail.tbid Like '" + txtSearch + "%' Or tbTable.tbdid Like '" + txtSearch.Text + "%'", con);
                da.Fill(table);
                for(int col = 0; col < table.Rows.Count; col++)
                {
                    dgvtable.Rows.Add(table.Rows[col][0].ToString(), table.Rows[col][1].ToString());
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void Save_To_TableDetail(string tbid)
        {
            try
            {
                table = new DataTable();
                da = new SqlDataAdapter("Select * From tbTableDetail Where tbid='" + tbid + "'", con);
                table.Clear();
                da.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    cmd = new SqlCommand("Insert Into tbTableDetail Values(@id1)", con);
                    cmd.Parameters.AddWithValue("id1", tbid);
                    cmd.ExecuteNonQuery();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error saving data to table tbTableDetail: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // Return 1 "Complete action" If Return 0 "Don't complete action"
        public int Save(string tbid, int tbqty)
        {
            try
            {
                qty = tbqty;

                Save_To_TableDetail(tbid);

                table = new DataTable();
                table.Clear();
                da = new SqlDataAdapter("select Max(tbdid) from tbTable Where tbid='" + tbid + "'", con);
                da.Fill(table);

                //MessageBox.Show(maxid = table.Rows[0][0].ToString());

                if (table.Rows.Count>0 && table.Rows[0][0].ToString()!="")
                {
                    maxid = table.Rows[0][0].ToString();
                    subid = int.Parse(maxid.Substring(1, maxid.Length-1));
                    //MessageBox.Show(maxid+"  "+subid.ToString());

                }


                for (int i = 1; i <= qty; i++)
                {
                    if (subid >= 1)
                    {
                        subid += 1;
                        if (subid < 10)
                        {
                            id2 = $"{tbid}00{subid}";
                        }
                        else if (subid >= 10 && subid < 100)
                        {
                            id2 = $"{tbid}0{subid}";
                        }
                        else
                        {
                            id2 = $"{tbid}{subid}";
                        }
                    }
                    else
                    {
                        if (i < 10)
                        {
                            id2 = $"{tbid}00{i}";
                        }
                        else if (i >= 10 && i < 100)
                        {
                            id2 = $"{tbid}0{i}";
                        }
                        else
                        {
                            id2 = $"{tbid}{i}";
                        }
                    }
                    // MessageBox.Show(id2.ToString());

                    cmd = new SqlCommand("Insert Into tbTable Values(@id1,@id2)", con);
                    cmd.Parameters.AddWithValue("id1", tbid);
                    cmd.Parameters.AddWithValue("id2", id2);
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        Show_data();
                        MyModel.fsh_action = 1;
                    }

                }
                subid = 0;
            }
            catch (Exception ex)
            {
                MyModel.fsh_action = 0;
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MyModel.fsh_action;
        }
        public int Edit(string tbdid)
        {
            try
            {
                cmd = new SqlCommand("Update tbTable Set tbdid=@id Where tbid=@id1 And tbdid=@id2", con);
                cmd.Parameters.AddWithValue("id1", id[0]);
                cmd.Parameters.AddWithValue("id2", id[1]);
                cmd.Parameters.AddWithValue("id", tbdid);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    Show_data();
                    MyModel.fsh_action = 1;
                }
                
            }
            catch (Exception ex)
            {
                MyModel.fsh_action = 0;
                MyMessageBox.ShowMesage("ແກ້ໄຂບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return MyModel.fsh_action;
        }
        private void Delete(string tbid, string tbdid)
        {
            try
            {
                DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະລົບຂໍ້ມູນອອກບໍ່?", "Warring", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    cmd = new SqlCommand("Delete From tbTable Where tbid=@id1 And tbdid=@id2", con);
                    cmd.Parameters.AddWithValue("id1", tbid);
                    cmd.Parameters.AddWithValue("id2", tbdid);
                    cmd.ExecuteNonQuery();
                    Show_data();
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ລົບບໍ່ສຳເລັດເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmTable_Load(object sender, EventArgs e)
        {
            Show_data();
        }
        
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
            tbtable = new frmEditTable(this);
            tbtable.ShowDialog();
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

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void dgvtable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                id[0] = dgvtable.Rows[e.RowIndex].Cells[0].Value.ToString();
                id[1] = dgvtable.Rows[e.RowIndex].Cells[1].Value.ToString();
            }

            if (e.ColumnIndex == 2)
            {
                tbtable = new frmEditTable(this);
                tbtable.id1 = dgvtable.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbtable.id2 = dgvtable.Rows[e.RowIndex].Cells[1].Value.ToString();
                tbtable.edit =true;
                tbtable.ShowDialog();
            }
            else if(e.ColumnIndex==3)
            {
                Delete(dgvtable.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvtable.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
        }


        private void txtid_TextChanged(object sender, EventArgs e)
        {

            /*table = new DataTable();
            table.Clear();
            da = new SqlDataAdapter("select Max(tbdid) from tbTable Where tbid='" + txtid.Text + "'", con);
            da.Fill(table);

            //MessageBox.Show(maxid = table.Rows[0][0].ToString());

            if (table.Rows.Count > 0 && table.Rows[0][0].ToString() != "")
            {
                maxid = table.Rows[0][0].ToString();
                subid = int.Parse(maxid.Substring(1, maxid.Length - 1));
                //MessageBox.Show(maxid+"  "+subid.ToString());

            }

            if (txtid.Text == "")
            {
                txtidd.Text = "";
                txtQty.Text = "";
            }
            else
            {
                if (subid >= 1)
                {
                    subid += 1;
                    if (subid < 10)
                    {
                        txtidd.Text = $"{txtid.Text}00{subid}";
                    }else if (subid >= 10 && subid<100)
                    {
                        txtidd.Text = $"{txtid.Text}0{subid}";
                    }
                    else
                    {
                        txtidd.Text = $"{txtid.Text}{subid}";
                    }
                    subid = 0;
                }
                else
                {
                    txtidd.Text = $"{txtid.Text}00{1}";
                }*/
            //txtQty.Text = "1";
           // }
        }
    }
}
