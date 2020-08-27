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
    public partial class frmSearch : Form
    {
        Form1 _home;
        public frmSearch(Form1 home)
        {
            InitializeComponent();
            _home = home;
            treeView_Books.ImageList = imageList1;
            
        }

        SqlConnection con = MyConnected.getConnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataSet ds;
        DataTable table;
        TreeNode tNode1, tNode2;
        AutoCompleteStringCollection auto;

        private void ShowDataToShearch()
        {
            try
            {
                auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select tbBooks_Detail.bname, tbCategory.name, tbType.typename From tbBooks_Detail Inner Join tbCategory On tbBooks_Detail.catgid=tbCategory.catgid Inner Join tbType On tbBooks_Detail.typeid = tbType.typeid", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auto.Add(dr["bname"].ToString());
                    auto.Add(dr["name"].ToString());
                    auto.Add(dr["typename"].ToString());
                }
                txtSearch.AutoCompleteCustomSource = auto;
                txtSearch.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtSearch.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }

        }
        private void Show_Data()
        {
            table = new DataTable();
            table.Clear();
            da = new SqlDataAdapter("Select bid, bname, Qty From tbBooks_Detail", con);
            da.Fill(table);
            for (int nod = 0; nod < table.Rows.Count; nod++)
            {
                try
                {
                    cmd = new SqlCommand(@"SELECT dbo.tbBooks.barcode, dbo.tbBooks_Detail.page, dbo.tbBooks_Detail.ISBN, dbo.tbCategory.name, dbo.tbType.typename, dbo.tbBooks_Detail.tbdid, dbo.tbBooks.status FROM   dbo.tbBooks INNER JOIN dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid Where tbBooks.bid='" + table.Rows[nod][0].ToString() + "'", con);
                    dr = cmd.ExecuteReader();
                    tNode1 = new TreeNode($"{table.Rows[nod][0].ToString()} : {table.Rows[nod][1].ToString()}  ຈຳນວນ: {table.Rows[nod][2].ToString()} ຫົວ");
                    tNode1.SelectedImageIndex = 0;
                    while (dr.Read())
                    {
                        tNode1.Nodes.Add(tNode2 = new TreeNode($"ລະຫັດ Barcode: {dr["barcode"].ToString()} ສະຖານະ: {dr["status"].ToString()}"));
                        tNode2.ImageIndex = 1;
                        tNode2.Nodes.Add($"ຈຳນວນໜ້າ: {dr["page"].ToString()}");
                        tNode2.Nodes.Add($"ISBN: {dr["ISBN"].ToString()}");
                        tNode2.Nodes.Add($"ໝວດ: {dr["name"].ToString()}");
                        tNode2.Nodes.Add($"ປະເພດ: {dr["typename"].ToString()}");
                        tNode2.Nodes.Add($"ລະຫັດຕູ້: {dr["tbdid"].ToString()}");
                    }
                    treeView_Books.Nodes.Add(tNode1);
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dr.Close();
                }
            }
        }
        private void Shearch_Data(string val)
        {
            table = new DataTable();
            table.Clear();
            da = new SqlDataAdapter("Select tbBooks_Detail.bid, tbBooks_Detail.bname, tbBooks_Detail.Qty From tbBooks_Detail Inner Join tbCategory On tbBooks_Detail.catgid=tbCategory.catgid Inner Join tbType On tbBooks_Detail.typeid = tbType.typeid Where tbBooks_Detail.bname Like N'%" + val + "%' Or tbCategory.name Like N'%" + val + "%' Or tbType.typename Like N'%" + val + "%'", con);
            da.Fill(table);
            for (int nod = 0; nod < table.Rows.Count; nod++)
            {
                try
                {
                    cmd = new SqlCommand(@"SELECT dbo.tbBooks.barcode, dbo.tbBooks_Detail.page, dbo.tbBooks_Detail.ISBN, dbo.tbCategory.name, dbo.tbType.typename, dbo.tbBooks_Detail.tbdid, dbo.tbBooks.status FROM   dbo.tbBooks INNER JOIN dbo.tbBooks_Detail ON dbo.tbBooks.bid = dbo.tbBooks_Detail.bid INNER JOIN dbo.tbCategory ON dbo.tbBooks_Detail.catgid = dbo.tbCategory.catgid INNER JOIN dbo.tbType ON dbo.tbBooks_Detail.typeid = dbo.tbType.typeid Where tbBooks.bid='" + table.Rows[nod][0].ToString() + "'", con);
                    dr = cmd.ExecuteReader();
                    tNode1 = new TreeNode($"{table.Rows[nod][0].ToString()} : {table.Rows[nod][1].ToString()}  ຈຳນວນ: {table.Rows[nod][2].ToString()} ຫົວ");
                    tNode1.SelectedImageIndex = 0;
                    while (dr.Read())
                    {
                        tNode1.Nodes.Add(tNode2 = new TreeNode($"ລະຫັດ Barcode: {dr["barcode"].ToString()} ສະຖານະ: {dr["status"].ToString()}"));
                        tNode2.ImageIndex = 1;
                        tNode2.Nodes.Add($"ຈຳນວນໜ້າ: {dr["page"].ToString()}");
                        tNode2.Nodes.Add($"ISBN: {dr["ISBN"].ToString()}");
                        tNode2.Nodes.Add($"ໝວດ: {dr["name"].ToString()}");
                        tNode2.Nodes.Add($"ປະເພດ: {dr["typename"].ToString()}");
                        tNode2.Nodes.Add($"ລະຫັດຕູ້: {dr["tbdid"].ToString()}");
                    }
                    treeView_Books.Nodes.Add(tNode1);
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການສະແດງຂໍ້ມູນ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dr.Close();
                }
            }

        }
        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            treeView_Books.Nodes.Clear();
            if (txtSearch.Text != "")
            {
                Shearch_Data(txtSearch.Text);
            }
            else
            {
                Show_Data();
            }
            
        }

        private void btSearch_Click(object sender, EventArgs e)
        {

        }

        private void btSearch_Click_1(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void frmSearch_Load(object sender, EventArgs e)
        {
            ShowDataToShearch();
            Show_Data();
        }
    }
}
