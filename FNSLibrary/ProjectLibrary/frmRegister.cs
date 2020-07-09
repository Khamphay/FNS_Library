using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;
using ZXing;
using System.IO;
using ProjectLibrary.Properties;
using ProjectLibrary.MSDialog;

namespace ProjectLibrary
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
            Detp_Load();
        }

        Form1 _home;
        public frmRegister(Form1 home)
        {
            InitializeComponent();
            _home = home;
            Detp_Load();
            btExit.Enabled = true;
        }


        DateTime date = new DateTime();
        //Construtor
        public frmRegister(string[] arr)
        {
            
            InitializeComponent();
            Detp_Load();
            txtid.Enabled = false;

            txtid.Text = arr[0];
            txtname.Text =arr[1];
            txtsurename.Text = arr[2];
            if (arr[3] == "ຊາຍ"){
                radimal.Checked=true;
            }
            else
            {
                radifiman.Checked = true;
            }
            txttel.Text = arr[4];
            txtvilla.Text = arr[5];
            txtdist.Text = arr[6];
            txtpro.Text = arr[7];
            birdDate.Text = arr[8];
            cmbDetp.SelectedItem = arr[9];
            dateRgt.Value =DateTime.ParseExact(arr[10], "dd-MM-yyyy", CultureInfo.InvariantCulture);
            dateEd.Value = DateTime.ParseExact(arr[11],"dd-MM-yyyy", CultureInfo.InvariantCulture);
        }


        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable table;
        SqlDataReader dr;
        DateTime dateNow, dateExpire, dayEx;
        string gender = "";
        string[] mycard;
        public bool status = false;
        AutoCompleteStringCollection autoshow = new AutoCompleteStringCollection();

        private void Detp_Load()
        {
            try
            {
                cmd = new SqlCommand("Select name From tbDepart", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //Display the values when your check select on the ComboBox
                    cmbDetp.Items.Add(dr["name"].ToString());
                    //Auto Complete value when your teyping on the ComboBox
                    autoshow.Add(dr["name"].ToString());
                }
                cmbDetp.AutoCompleteCustomSource = autoshow;
                cmbDetp.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbDetp.AutoCompleteSource = AutoCompleteSource.CustomSource;

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error show detpartment data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void PrintCard()
        {
            //#1===========================================
            //mycard = new string[] { 
            //    txtid.Text, 
            //    txtname.Text,
            //    txtsurename.Text ,
            //    birdDate.Value.ToString("dd-MM-yyyy"), 
            //    dateRgt.Value.ToString("dd-MM-yyyy"),
            //    dateNow.AddYears(4).ToString("dd-MM-yyyy")
            //};
            //frmCard card = new frmCard(mycard);
            //card.ShowDialog();
            //if (card.Visible == false)
            //{
            //    ClearData();
            //}

            //#2============================================
            //Barcode
            BarcodeWriter barcode = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
            PictureBox picbarcode = new PictureBox();
            picbarcode.Image = barcode.Write(txtid.Text);
            MemoryStream memoryStream = new MemoryStream();
            picbarcode.Image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Png);
            //Logo
            MemoryStream memory = new MemoryStream();
            
            Image img =Resources.Logo;
            img.Save(memory, img.RawFormat);


            DateTime year = dateNow.AddYears(4);
            string y1, y2, y3, y4;

            y1 = year.AddYears(-4).ToString("yyyy") + "-" + year.AddYears(-3).ToString("yyyy");
            y2 = year.AddYears(-3).ToString("yyyy") + "-" + year.AddYears(-2).ToString("yyyy");
            y3 = year.AddYears(-2).ToString("yyyy") + "-" + year.AddYears(-1).ToString("yyyy");
            y4 = year.AddYears(-1).ToString("yyyy") + "-" + year.AddYears(0).ToString("yyyy");


            MyModel.tablecard.Rows.Add(
                txtid.Text,
                txtname.Text + " " + txtsurename.Text,
                birdDate.Value,
                dateRgt.Value,
                year,
                memoryStream.ToArray(),
                y1,
                y2,
                y3,
                y4
                );
        }
        private void Save()
        {
            try
            {
                if (txtid.Text!="" && txtname.Text!="" && txtsurename.Text!="" && txtvilla.Text!=""&& txtdist.Text!="" && txtpro.Text!="") {
                    if (radimal.Checked == true)
                    {
                        gender = radimal.Text;
                    }
                    else
                    {
                        gender = radifiman.Text;
                    }


                    cmd = new SqlCommand("Insert Into tbMember Values(@id,@fname,@lname,@gender,@tel,@villa,@dist,@pro,@birdate,@detp,@dateRgt,@dateEd)", con);
                    cmd.Parameters.AddWithValue("id", txtid.Text);
                    cmd.Parameters.AddWithValue("fname", txtname.Text);
                    cmd.Parameters.AddWithValue("lname", txtsurename.Text);
                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters.AddWithValue("tel", txttel.Text);
                    cmd.Parameters.AddWithValue("villa", txtvilla.Text);
                    cmd.Parameters.AddWithValue("dist", txtdist.Text);
                    cmd.Parameters.AddWithValue("pro", txtpro.Text);
                    cmd.Parameters.AddWithValue("birdate", DbType.Date).Value = birdDate.Value;
                    cmd.Parameters.AddWithValue("detp", cmbDetp.Text);
                    cmd.Parameters.AddWithValue("dateRgt", DbType.Date).Value = dateRgt.Value;
                    cmd.Parameters.AddWithValue("dateEd", DbType.Date).Value = dateEd.Value;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        MyMessageBox.ShowMesage("ບັນທືກຂໍ້ມູນສຳເລັດແລ້ວ", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        PrintCard();
                    }
                }
                else
                {
                    MyMessageBox.ShowMesage("ກະລຸນາກວດສອບຂໍ້ມູນ ແລະ ລອງໃຫມ່ອີກຄັ້ງ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ບັນທືກບໍ່ສຳເລັດ ເນື່ອງຈາກເກີດບັນຫາ: "+ex.Message, "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void Edit()
        {
            try
            {
                if (txtid.Text != "" && txtname.Text != "" && txtsurename.Text != "" && txtvilla.Text != "" && txtdist.Text != "" && txtpro.Text != "")
                {
                    if (radimal.Checked == true)
                    {
                        gender = radimal.Text;
                    }
                    else
                    {
                        gender = radifiman.Text;
                    }


                    cmd = new SqlCommand("Update tbMember Set fname=@fname, lname=@lname, gender=@gender, tel=@tel, village=@villa, district=@dist, province=@pro, birdate=@birdate, detpname=@detp, dateRgt=@dateRgt, dateREd=@dateEd Where mid=@id", con);

                    cmd.Parameters.AddWithValue("id", txtid.Text);
                    cmd.Parameters.AddWithValue("fname", txtname.Text);
                    cmd.Parameters.AddWithValue("lname", txtsurename.Text);
                    cmd.Parameters.AddWithValue("gender", gender);
                    cmd.Parameters.AddWithValue("tel", txttel.Text);
                    cmd.Parameters.AddWithValue("villa", txtvilla.Text);
                    cmd.Parameters.AddWithValue("dist", txtdist.Text);
                    cmd.Parameters.AddWithValue("pro", txtpro.Text);
                    cmd.Parameters.AddWithValue("birdate", DbType.Date).Value = birdDate.Value;
                    cmd.Parameters.AddWithValue("detp", cmbDetp.Text);
                    cmd.Parameters.AddWithValue("dateRgt", DbType.Date).Value = dateRgt.Value;
                    cmd.Parameters.AddWithValue("dateEd", DbType.Date).Value = dateEd.Value;
                    if (cmd.ExecuteNonQuery() == 1)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MyMessageBox.ShowMesage("ກະລຸນາກວດສອບຂໍ້ມູນ ແລະ ລອງໃຫມ່ອີກຄັ້ງ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MyMessageBox.ShowMesage("ແກ້ໄຂບໍ່ສຳເລັດ ເນື່ອງຈາກເກີດບັນຫາ: " + ex.Message, "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
        private void ClearData()
        {
            txtid.Clear();
            txtname.Clear();
            txtsurename.Clear();
            txttel.Clear();
            txtvilla.Clear();
            txtpro.Clear();
            txttel.Clear();
            txtdist.Clear();
            cmbDetp.ResetText();
        }
        private void btsave_Click(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Clear();
            da = new SqlDataAdapter("Select mid From tbMember Where mid='" + txtid.Text+"'",con);
            da.Fill(table);

            if (table.Rows.Count<=0)
            {
                Save();
            }
            else
            {
                Edit();
            }
            
        }

        private void frmRegister_Load(object sender, EventArgs e)
        {
            if(txtid.Text=="" && txtname.Text == "")
            {
                dateRgt.Value = DateTime.Now;
            }
            // Load this model use for Switch Language when you focus the textBox 
            MyModel.getSwitchLanguage();
            DateTime dtExpireCard = dateEd.Value;
            if (dtExpireCard.CompareTo(DateTime.Now) == 0)
            {
                lbWarringCardExpire.Text = "ບັດນີ້ໝົດອາຍຸແລ້ວ. ກະລຸນາຕໍ່ບັດຈື່ງສາມາດໃຊ້ງານໄດ້";
            }
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            //Switch anothor Language to English Language
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void KeyNextEnter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtname_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void txtsurename_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void txttel_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }

        private void txtvilla_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void txtdist_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void txtpro_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyLatter(e);
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            status = false;
            this.Close();
            _home.ShowHomePage();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {
            if (status == false)
            {
                _home.Clear_PanelMenu();
            }
        }

        private void frmRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            status = false;
        }

        private void btPrint_Click(object sender, EventArgs e)
        {
            if (txtid.Enabled == false)
            {
                //Fill information to MyModel.tablecard
                PrintCard();
            }
            frmPrintMemberCard membercard = new frmPrintMemberCard(MyModel.tablecard);
            membercard.Show();
        }

        private void txttel_Enter(object sender, EventArgs e)
        {
            //Switch anothor Language to English Language
            InputLanguage.CurrentInputLanguage = MyModel.eng;

        }

        private void dateRgt_ValueChanged(object sender, EventArgs e)
        {
            dateNow = DateTime.Now;
            if (dateNow.CompareTo(dateRgt.Value) == 0 || dateNow.CompareTo(dateRgt.Value) ==1)
            {
                int year = int.Parse(dateNow.Year.ToString());
                year += 1;
                dateExpire = new DateTime(year, 09, 30);
                dateEd.Value=dateExpire;
            }
            else
            {
                dateRgt.Value = DateTime.Now;
            }
        }
    }
}
