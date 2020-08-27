using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.IO;
using ProjectLibrary.MSDialog;

namespace ProjectLibrary
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            EnableMenuBar();
            //if()
            //pnBorderTop.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        SqlConnection con = MyConnected.getConnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlDataReader dr;
        DataTable dttable;
        DateTime dateNow = DateTime.Now;

        //Resize Form
        private const int griphic = 16, caption=32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point p = new Point(m.LParam.ToInt32());
                p = this.PointToClient(p);
                if (p.Y < caption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (p.X >= this.ClientSize.Width - griphic && p.Y >= this.ClientSize.Height - griphic)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        
        frmAuthor author;
        frmBooksDetial booksdetial;
        frmStaff emp;
        frmMember member;
        frmTable table;
        frmCategory catg;
        frmType type;
        frmDetpart depart;
        frmRentBook rent;
        frmReserve reserve;

        //Move the form
        bool mouseDrag;
        // Thenical 1:
        int mouseX = 0, mouseY = 0;
        // Thenical 2:
        private Point mousePt;
        int mouse = 0, mouX = 0, mouY = 0;

        private void EnableMenuBar()
        {
            pnAdminMenu.Width = 0;
            btBooksMenu.Enabled = false;
            btPersonMenu.Enabled = false;
            btRegister.Enabled = false;
            btReportMenu.Enabled = false;
            btServiceMenu.Enabled = false;
            lbStatus.Text = "ສະຖານະ: ທ່ານຍັງບໍ່ໄດ້ເຂົ້າລະບົບ";
            lbID.ResetText();
            lbName.ResetText();
            lbTel.ResetText();
        }

        public void Login(string username, string pass, Form login)
        {
            if (username != "" && pass != "")
            {
                try
                {
                    cmd = new SqlCommand("Select empid, fname, lname, tel, user_name, password From vw_User Where user_name=N'" + username+ "' And password=N'" + pass + "'", con);
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {
                        dr.Read();
                        MyModel.staff[0] = dr["empid"].ToString();
                        MyModel.staff[1] = dr["fname"].ToString();
                        MyModel.staff[2] = dr["lname"].ToString();
                        MyModel.staff[3] = dr["tel"].ToString();
                        MyModel.staff[4] = dr["user_name"].ToString();
                        MyModel.staff[5] = dr["password"].ToString();
                        if (MyModel.staff != null && MyModel.staff[4] == username && MyModel.staff[5] == pass)
                        {
                            lbID.Text = MyModel.staff[0];
                            lbName.Text = $"{MyModel.staff[1]} {MyModel.staff[2]}";
                            lbTel.Text = MyModel.staff[3];

                            login.Close();
                            //Show Main menu
                            pnAdminMenu.Width = 609;
                            btBooksMenu.Enabled = true;
                            btPersonMenu.Enabled = true;
                            btRegister.Enabled = true;
                            btReportMenu.Enabled = true;
                            btServiceMenu.Enabled = true;
                            ClickLogIn_Out();
                            lbStatus.Text= "ສະຖານະ: ເຂົ້າລະບົບແລ້ວ (ກະລຸນາອອກຈາກລະບົບເມື່ອບໍ່ໃຊ້ງານແລ້ວ)";

                            MyModel.table_staff.Rows.Add(MyModel.staff[0], MyModel.staff[1], MyModel.staff[2], MyModel.staff[3]);

                        }
                        else
                            MyMessageBox.ShowMesage("ຊື່ ແລະ ລະຫັດຜ່ານບໍ່ຖຶກຕ້ອງ. ກະລຸນາກວດສອບແລັວລອງໃໝ່ແລ້ວອີກຄັ້ງ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MyMessageBox.ShowMesage("ຊື່ ແລະ ລະຫັດຜ່ານບໍ່ຖຶກຕ້ອງ. ກະລຸນາກວດສອບແລັວລອງໃໝ່ແລ້ວອີກຄັ້ງ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MyMessageBox.ShowMesage("ເກີດບັນຫາໃນການເຂົ້າລະບົບ: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    dr.Close();
                }
            }
            else
            {
                MyMessageBox.ShowMesage("ຊື່ ແລະ ລະຫັດຜ່ານບໍ່ຖຶກຕ້ອງ. ກະລຸນາກວດສອບແລັວລອງໃໝ່ແລ້ວອີກຄັ້ງ", "Login", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void DateleifExpireReservetion()
        {
            try
            {
                dttable = new DataTable();
                dttable.Clear();
                cmd = new SqlCommand(@"Select tbReserve.barcode, tbReserve_Detail.dateEd, tbBooks.bid
                                        From tbReserve INNER JOIN tbReserve_Detail
                                        On tbReserve.rsid = tbReserve_Detail.rsid 
										Inner Join tbBooks On tbReserve.barcode=tbBooks.barcode
                                        Where tbReserve_Detail.dateEd < @dateNow", con);
                cmd.Parameters.AddWithValue("dateNow", DbType.Date).Value = dateNow.ToString("yyyy-MM-dd");
                da = new SqlDataAdapter(cmd);

                da.Fill(dttable);
                if (dttable.Rows.Count > 0)
                {
                    //if (dateNow.CompareTo(DateTime.Parse(dttable.Rows[0][1].ToString())) == 1)
                    //{
                    //Delete from tbReserve_Detail
                    cmd = new SqlCommand("Delete From tbReserve_Detail Where dateEd<@dateNow OR qty<=0", con);
                    cmd.Parameters.AddWithValue("dateNow", DbType.Date).Value = dateNow.ToString("yyyy-MM-dd");
                    cmd.ExecuteNonQuery();
                    //}
                    for (int row = 0; row < dttable.Rows.Count; row++)
                    {
                        //Update status tbBooks
                        cmd = new SqlCommand("Update tbBooks Set status=N'ຫວ່າງ' Where barcode=@barcode", con);
                        cmd.Parameters.AddWithValue("barcode", dttable.Rows[row][0].ToString());
                        cmd.ExecuteNonQuery();

                        //Update Qty of tbBooksDetail
                        cmd = new SqlCommand("Update tbBooks_Detail Set reserQty-=1 Where bid=@id", con);
                        cmd.Parameters.AddWithValue("id", dttable.Rows[row][2].ToString());
                        cmd.ExecuteNonQuery();
                    }
                    //MessageBox.Show("Delete exipire of reserve books", "Reservetion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error delete exipire of reserve books: " + ex.Message, "Reservetion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void ShowSubForm(Form frm)
        {
            pnPersonMenu.Width = 0;
            pnServiceMenu.Width = 0;
            pnReportMenu.Width = 0;
            pnMenuBook.Width = 0;
            if (pnShowFrm.Controls.Count > 0)
            {
                pnShowFrm.Controls.RemoveAt(0);
            }
            frm.TopLevel = false;
            frm.TopMost = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnShowFrm.Controls.Add(frm);
            frm.Show();
        }
        public void ShowHomePage()
        {
            HomePage home = new HomePage(this);
            pnPersonMenu.Width = 0;
            pnServiceMenu.Width = 0;
            pnReportMenu.Width = 0;
            pnMenuBook.Width = 0;

            if (pnShowFrm.Controls.Count > 0)
            {
                pnShowFrm.Controls.RemoveAt(0);
            }
            home.Dock = DockStyle.Fill;
            pnShowFrm.Controls.Add(home);
        }

        public void ClickLogIn_Out()
        {
            HomePage home = new HomePage(this);
            pnPersonMenu.Width = 0;
            pnServiceMenu.Width = 0;
            pnReportMenu.Width = 0;
            pnMenuBook.Width = 0;
            if (pnShowFrm.Controls.Count > 0)
            {
                pnShowFrm.Controls.RemoveAt(0);
            }
            home.Dock = DockStyle.Fill;
            pnShowFrm.Controls.Add(home);
        }
        public void LogOut()
        {
            DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະອອກຈາກລະບົບບໍ່?", "Log out", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                //this.Hide();
                lbID.ResetText();
                lbName.ResetText();
                lbTel.ResetText();
                MyModel.staff[0] = null;
                MyModel.staff[1] = null;
                MyModel.staff[2] = null;
                MyModel.staff[3] = null;
                MyModel.staff[4] = null;
                MyModel.staff[5] = null;
                EnableMenuBar();
                ClickLogIn_Out();
                MyModel.table_staff.Rows.Clear();
            }
        }

        public void ShowRentBooks_From_Reserve(Form frm)
        {
            ShowSubForm(frm);
        }
        public void Clear_PanelMenu()
        {
            pnPersonMenu.Width = 0;
            pnServiceMenu.Width = 0;
            pnReportMenu.Width = 0;
            pnMenuBook.Width = 0;
        }
        
        private void gunaAdvenceButton6_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MyMessageBox.ShowMesage("ທ່ານແນ່ໃຈທີ່ຈະອອກຈາກໂປຣແກຣມບໍ່?", "Exit Programe", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gunaAdvenceButton2_Click(object sender, EventArgs e)
        {
            if (pnMenuBook.Width < 218)
            {
                pnPersonMenu.Width = 0;
                pnServiceMenu.Width = 0;
                pnReportMenu.Width = 0;
                pnMenuBook.Width = 218;
            }
            else if (pnMenuBook.Width >= 218)
            {
                pnMenuBook.Width = 0;
            }
            
        }

        private void gunaAdvenceButton3_Click(object sender, EventArgs e)
        {
            if (pnPersonMenu.Width < 218)
            {
                pnServiceMenu.Width = 0;
                pnReportMenu.Width = 0;
                pnMenuBook.Width = 0;
                pnPersonMenu.Width = 218;
                
            }
            else if (pnPersonMenu.Width >= 218)
            {
                pnPersonMenu.Width = 0;
            }
        }

        private void gunaAdvenceButton4_Click(object sender, EventArgs e)
        {
            if (pnServiceMenu.Width < 218)
            {
                pnReportMenu.Width = 0;
                pnMenuBook.Width = 0;
                pnPersonMenu.Width = 0;
                pnServiceMenu.Width = 218;
            }
            else if (pnServiceMenu.Width >= 218)
            {
                pnServiceMenu.Width = 0;
            }
        }

        private void gunaAdvenceButton5_Click(object sender, EventArgs e)
        {
            if (pnReportMenu.Width < 218)
            {
                pnMenuBook.Width = 0;
                pnPersonMenu.Width = 0;
                pnServiceMenu.Width = 0;
                pnReportMenu.Width = 218;
            }
            else if (pnReportMenu.Width >= 218)
            {
                pnReportMenu.Width = 0;
            }
        }

        private void btType_Click(object sender, EventArgs e)
        {
            type = new frmType(this);
            ShowSubForm(type);
        }

        private void btCatecory_Click(object sender, EventArgs e)
        {
            catg = new frmCategory(this);
            ShowSubForm(catg);
        }

        private void btBookGroup_Click(object sender, EventArgs e)
        {
            //book = new frmBooks(this);
            //ShowSubForm(book);
        }

        private void btBooks_Click(object sender, EventArgs e)
        {
            booksdetial = new frmBooksDetial(this);
            ShowSubForm(booksdetial);
        }

        private void btTable_Click(object sender, EventArgs e)
        {
            table = new frmTable(this);
            ShowSubForm(table);
        }

        private void btDepart_Click(object sender, EventArgs e)
        {
            depart = new frmDetpart(this);
            ShowSubForm(depart);
        }

        private void btRegisterCost_Click(object sender, EventArgs e)
        {
            frmCost cost = new frmCost();
            cost.ShowDialog();
        }

        private void btFine_Click(object sender, EventArgs e)
        {
            frmFine fine = new frmFine();
            fine.ShowDialog();
        }

        private void btStaff_Click(object sender, EventArgs e)
        {
            emp = new frmStaff(this);
            ShowSubForm(emp);
        }

        private void btUser_Click(object sender, EventArgs e)
        {
            frmNewUser user = new frmNewUser(this);
            ShowSubForm(user);
        }

        private void btMemer_Click(object sender, EventArgs e)
        {
            member = new frmMember(this);
            ShowSubForm(member);
        }

        private void btAuthor_Click(object sender, EventArgs e)
        {
            author = new frmAuthor(this);
            ShowSubForm(author);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            frmSearch search = new frmSearch(this);
            ShowSubForm(search);
        }

        private void btRent_Return_Click(object sender, EventArgs e)
        {
            rent = new frmRentBook(this);
            ShowSubForm(rent);
        }

        private void btReserveBook_Click(object sender, EventArgs e)
        {
            reserve = new frmReserve(this);
            ShowSubForm(reserve);
        }

        private void pnShowFrm_MouseClick(object sender, MouseEventArgs e)
        {
            Clear_PanelMenu();
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void btRegister_Click(object sender, EventArgs e)
        {
            frmRegister register = new frmRegister(this);
            register.status = false;
            ShowSubForm(register);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            // Thenical 1: And // Thenical 2.1:
            mouseDrag = true;
            // Thenical 2.2:
            //mousePt = new Point(e.X, e.Y);
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            // Thenical 1: And  // Thenical 2
            mouseDrag = false;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ShowHomePage();
            //Connect to DataTable on file DataSource "DsBarcode.xsd" (Using For print barcode)
            //#1 
            MyModel.table = new DataTable();
            MyModel.table.TableName = "dtBarcode";
            MyModel.table.Columns.Add("Barcode", typeof(string));
            MyModel.table.Columns.Add("Image", typeof(Byte[]));

            //#2
            MyModel.tablecard = new DataTable();
            MyModel.tablecard.TableName = "tbMemberCard";
            MyModel.tablecard.Columns.Add("mid", typeof(string));
            MyModel.tablecard.Columns.Add("fname", typeof(string));
            MyModel.tablecard.Columns.Add("birdate", typeof(DateTime));
            MyModel.tablecard.Columns.Add("dateRgt", typeof(DateTime));
            MyModel.tablecard.Columns.Add("dateREd", typeof(DateTime));
            MyModel.tablecard.Columns.Add("barcodeid", typeof(Byte[]));
            MyModel.tablecard.Columns.Add("Y1", typeof(string));
            MyModel.tablecard.Columns.Add("Y2", typeof(string));
            MyModel.tablecard.Columns.Add("Y3", typeof(string));
            MyModel.tablecard.Columns.Add("Y4", typeof(string));

            //Staff
            MyModel.table_staff = new DataTable();
            MyModel.table_staff.TableName = "tbStaff";
            MyModel.table_staff.Columns.Add("ID",typeof(string));
            MyModel.table_staff.Columns.Add("Name",typeof(string));
            MyModel.table_staff.Columns.Add("Surename", typeof(string));
            MyModel.table_staff.Columns.Add("Tel", typeof(string));


            DateleifExpireReservetion();
        }

        private void btReturnbooks_Click(object sender, EventArgs e)
        {
            frmReturnBooks returnbooks = new frmReturnBooks(this);
            ShowSubForm(returnbooks);
        }

        private void btBack1_Click(object sender, EventArgs e)
        {
            pnMenuBook.Width = 0;
        }

        private void btBack2_Click(object sender, EventArgs e)
        {
            pnPersonMenu.Width = 0;
        }

        private void btBack3_Click(object sender, EventArgs e)
        {
            pnReportMenu.Width = 0;
        }

        private void btBack4_Click(object sender, EventArgs e)
        {
            pnServiceMenu.Width = 0;
        }

        private void btReportBooks_Lost_Click(object sender, EventArgs e)
        {
            frmReportBooksLost Replost = new frmReportBooksLost(this);
            ShowSubForm(Replost);
        }

        private void MouseMoveForm(object sender, MouseEventArgs e)
        {
            if (mouse == 1)
            {
                this.SetDesktopLocation(MousePosition.X - mouX, MousePosition.Y - mouY);
            }
        }

        private void UpMovedForm(object sender, MouseEventArgs e)
        {
            mouse = 0;
        }

        private void btReportMember_Click(object sender, EventArgs e)
        {
            frmReportMember member = new frmReportMember(this);
            ShowSubForm(member);
        }

        private void MoveForm(object sender, MouseEventArgs e)
        {
            mouse = 1;
            mouX = e.X;
            mouY = e.Y;
        }

        private void gunaAdvenceButton8_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaAdvenceButton7_Click(object sender, EventArgs e)
        {
            if (WindowState.Equals(FormWindowState.Normal))
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
    }
}
