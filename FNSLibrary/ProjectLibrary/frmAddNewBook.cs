﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ZXing;
using System.IO;
using System.Drawing.Imaging;

namespace ProjectLibrary
{
    public partial class frmAddNewBook : Form
    {
        frmBooksDetial _bookdt;
        
        public frmAddNewBook(frmBooksDetial bookdt, string[] data, string bid)
        {
            InitializeComponent();
            _bookdt = bookdt;

            if (data != null && bid != "")
            {
                txtid.Enabled = false;
                txtqty.Enabled = false;
                //Use sub Books ID
                int indx = 0, count = 0;
                //char[] ch = data[0].ToCharArray();

                //for (int i = 0; i < ch.Length; i++)
                //{
                //    if (char.IsLetter(ch[i]))
                //    {
                //        indx += 1;
                //    }
                //}
                //txtid.Text=data[0].Substring(0, indx);
                txtid.Text = bid;
                barcode = data[0];
                txtname.Text = data[1];
                txtPage.Text = data[2];
                txtISBN.Text = data[3];
                txtqty.Text = "1";
                cname = data[4];
                typename = data[5];
                cmbTable.Text = data[6];
                cmbStatus.SelectedItem = data[7];

                cmd = new SqlCommand("Select fname From tbAthor Inner Join tbWrite On tbAthor.athid=tbWrite.athid Where tbWrite.bid='" + txtid.Text + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    authname[count] = dr["fname"].ToString();
                    count += 1;
                }
                dr.Close();
            }
            else
            {
                cmbStatus.SelectedIndex = 0;
            }
        }

        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataReader dr;
        AutoCompleteStringCollection my_auto;

        string bid = "", catgid = "", typeid = "", barcode = "", cname = "", typename="";
        string[] auth = new string[4];
        string[] authname = new string[4];

        int id = 0;

        private void LoadBg_Name()
        {
           /* try
            {
                my_auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select bgName From tbBooks", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbGroup.Items.Add(dr["bgName"].ToString());
                    my_auto.Add(dr["bgName"].ToString());
                }
                cmbGroup.AutoCompleteCustomSource = my_auto;
                cmbGroup.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbGroup.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error load books group data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }*/
        }
        private void LoadCtg_Name()
        {
            try
            {
                my_auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select name From tbCategory", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbCtg.Items.Add(dr["name"].ToString());
                    my_auto.Add(dr["name"].ToString());
                }
                cmbCtg.AutoCompleteCustomSource = my_auto;
                cmbCtg.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCtg.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error books category data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void LoadType_name()
        {
            try
            {
                my_auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select typename From tbType", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbType.Items.Add(dr["typename"].ToString());
                    my_auto.Add(dr["typename"].ToString());
                }
                cmbType.AutoCompleteCustomSource = my_auto;
                cmbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbType.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error books type data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }
        private void Load_Author()
        {
            try
            {
                my_auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select fname From tbAthor", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbAuthor1.Items.Add(dr["fname"].ToString());
                    cmbAuthor2.Items.Add(dr["fname"].ToString());
                    cmbAuthor3.Items.Add(dr["fname"].ToString());
                    cmbAuthor4.Items.Add(dr["fname"].ToString());
                    my_auto.Add(dr["fname"].ToString());
                }

                //Author 1
                cmbAuthor1.AutoCompleteCustomSource = my_auto;
                cmbAuthor1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbAuthor1.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //Author 2
                cmbAuthor2.AutoCompleteCustomSource = my_auto;
                cmbAuthor2.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbAuthor2.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //Author 3
                cmbAuthor3.AutoCompleteCustomSource = my_auto;
                cmbAuthor3.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbAuthor3.AutoCompleteSource = AutoCompleteSource.CustomSource;

                //Author 4
                cmbAuthor4.AutoCompleteCustomSource = my_auto;
                cmbAuthor4.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbAuthor4.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch (Exception ex)
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
                my_auto = new AutoCompleteStringCollection();
                cmd = new SqlCommand("Select tbdid From tbTable", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    cmbTable.Items.Add(dr["tbdid"].ToString());
                    my_auto.Add(dr["tbdid"].ToString());
                }
                cmbTable.AutoCompleteCustomSource = my_auto;
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
        private void MaxID()
        {
            try
            {
                int index = 0;
                char[] ii;

                cmd = new SqlCommand("Select MAX(barcode) as maxid From tbBooks Where bid Like N'" + txtid.Text + "%'", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows && dr["maxid"].ToString() != "")
                {
                    bid = dr["maxid"].ToString();
                    ii = bid.ToCharArray();
                    for (int i = 0; i < ii.Length; i++)
                    {
                        if (char.IsLetter(ii[i]))
                        {
                            index += 1;
                        }
                    }
                    id = int.Parse(bid.Substring(index));
                    txtid_Barcode.Text = $"{txtid.Text}000{(id + 1).ToString()}";
                }
                else
                {
                    txtid_Barcode.Text = $"{txtid.Text}000{1}";
                    id = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error max id: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }

        }
        private void Save()
        {
            try
            {
                cmd = new SqlCommand("Insert Into tbBooks_Detail(bid, bname, page, ISBN, Qty, catgid, typeid, tbdid) Values(@id, @name, @page, @isbn, @qty, @cid, @tid, @tbid)", con);
                cmd.Parameters.AddWithValue("id", txtid.Text);
                cmd.Parameters.AddWithValue("name", txtname.Text);
                cmd.Parameters.AddWithValue("page", txtPage.Text);
                cmd.Parameters.AddWithValue("qty", txtqty.Text);
                cmd.Parameters.AddWithValue("isbn", txtISBN.Text);
                cmd.Parameters.AddWithValue("cid", catgid);
                cmd.Parameters.AddWithValue("tid", typeid);
                cmd.Parameters.AddWithValue("tbid", cmbTable.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    for(int j = 0; j < auth.Length; j++)
                    {
                        if (auth[j] != null)
                        {
                            cmd = new SqlCommand("Insert Into tbWrite Values(@id, @athid, @year)",con);
                            cmd.Parameters.AddWithValue("id", txtid.Text);
                            cmd.Parameters.AddWithValue("athid", auth[j]);
                            cmd.Parameters.AddWithValue("year", dateAuth.Value.ToString("yyyy"));
                            int s=cmd.ExecuteNonQuery();
                        }
                        
                    }
                    for (int i = 1; i <= int.Parse(txtqty.Text); i++)
                    {
                        if (id > 0)
                        {
                            id += 1;
                            if (id < 10)
                            {
                                bid = $"{txtid.Text}000{id}";
                            }
                            else if (id >= 10 && id < 100)
                            {
                                bid = $"{txtid.Text}00{i}";
                            }
                            else if (id >= 100 && id < 1000)
                            {
                                bid = $"{txtid.Text}0{id}";
                            }
                            else
                            {
                                bid = $"{txtid.Text}{id}";
                            }
                        }
                        else
                        {
                            if (i < 10)
                            {
                                bid = $"{txtid.Text}000{i}";
                            }
                            else if (i >= 10 && i < 100)
                            {
                                bid = $"{txtid.Text}00{i}";
                            }
                            else if (i >= 100 && i < 1000)
                            {
                                bid = $"{txtid.Text}0{i}";
                            }
                            else
                            {
                                bid = $"{txtid.Text}{i}";
                            }
                        }

                        cmd = new SqlCommand("Insert Into tbBooks Values(@barcode, @bid, @status)", con);
                        cmd.Parameters.AddWithValue("barcode", bid);
                        cmd.Parameters.AddWithValue("bid", txtid.Text);
                        cmd.Parameters.AddWithValue("status", cmbStatus.Text);
                        if (cmd.ExecuteNonQuery() == 1)
                        {
                            _bookdt.Show_Data();
                        }
                    }
                    
                    //Print Barcode
                    int CountLine = txtid_Barcode.Lines.Length - 1;
                    string[] data = new string[CountLine];
                    for (int i = 0; i < CountLine; i++)
                    {
                        data[i] = txtid_Barcode.Lines[i];
                        PictureBox picBarCode = new PictureBox();
                        BarcodeWriter barcode = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };

                        picBarCode.Name = "picBar" + i;
                        // MessageBox.Show(data[i]);
                        picBarCode.Image = barcode.Write(data[i]);
                        picBarCode.SizeMode = PictureBoxSizeMode.StretchImage;
                        picBarCode.Height = 80;
                        MemoryStream memo = new MemoryStream();
                        picBarCode.Image.Save(memo, ImageFormat.Png);
                        byte[] image = memo.ToArray();

                        MyModel.table.Rows.Add(data[i], image);
                    }
                    ClearData();
                    MessageBox.Show("Save Completed", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                bid = "";
                id = 0;
            }
        }
        private void Edit()
        {
            try
            {
                cmd.ExecuteNonQuery();
                cmd = new SqlCommand("Update tbBooks_Detail Set  bname=@name, page=@page, ISBN=@isbn, catgid=@cid, typeid=@tid, tbdid=@tbid Where bid=@id", con);
                cmd.Parameters.AddWithValue("id", txtid.Text);
                cmd.Parameters.AddWithValue("name", txtname.Text);
                cmd.Parameters.AddWithValue("page", txtPage.Text);
                //cmd.Parameters.AddWithValue("qty", txtqty.Text);
                cmd.Parameters.AddWithValue("isbn", txtISBN.Text);
                cmd.Parameters.AddWithValue("cid", catgid);
                cmd.Parameters.AddWithValue("tid", typeid);
                cmd.Parameters.AddWithValue("tbid", cmbTable.Text);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    cmd = new SqlCommand("Update tbBooks Set bid=@bid, status=@status Where barcode=@barcode", con);
                    cmd.Parameters.AddWithValue("barcode", barcode);
                    cmd.Parameters.AddWithValue("bid", txtid.Text);
                    cmd.Parameters.AddWithValue("status", cmbStatus.Text);
                    cmd.ExecuteNonQuery();
                    for (int j = 0; j < auth.Length; j++)
                    {
                        if (auth[j] != null)
                        {
                            cmd = new SqlCommand("Update tbWrite Set athid=@athid, [Year]=@year Where bid=@id1 And athid=@id2", con);
                            cmd.Parameters.AddWithValue("id1", txtid.Text);
                            cmd.Parameters.AddWithValue("id2", auth[j]);
                            cmd.Parameters.AddWithValue("athid", auth[j]);
                            cmd.Parameters.AddWithValue("year", dateAuth.Value.ToString("yyyy"));
                            cmd.ExecuteNonQuery();
                        }
                    }
                    _bookdt.Show_Data();
                    ClearData();
                    MessageBox.Show("Edit Completed","Edit", MessageBoxButtons.OK,MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearData()
        {
            txtid.Clear();
            txtid_Barcode.Clear();
            txtISBN.Clear();
            txtname.Clear();
            txtPage.Text = "0";
            txtqty.Text = "0";
            txtSurname1.Clear();
            txtSurname2.Clear();
            txtSurname3.Clear();
            txtSurname4.Clear();
            cmbCtg.ResetText();
            cmbType.ResetText();
            cmbTable.ResetText();
            cmbAuthor1.ResetText();
            cmbAuthor2.ResetText();
            cmbAuthor3.ResetText();
            cmbAuthor4.ResetText();
            bid = "";
            barcode = "";
            catgid = "";
            typeid = "";
            id = 0;
            for (int i = 0; i< auth.Length; i++){
                auth[i] = null;
            }
        }

        private void frmAddNewBook_Load(object sender, EventArgs e)
        {
            MyModel.getSwitchLanguage();


          //  MaxID();
            LoadCtg_Name();
            LoadType_name();
            Load_Author();
            Load_Table();

            cmbCtg.SelectedItem = cname;
            cmbType.SelectedItem = typename;

            ComboBox[] combo = { cmbAuthor1, cmbAuthor2, cmbAuthor3, cmbAuthor4 };
            for (int i = 0; i < authname.Length; i++)
            {
                if (authname[i] != null)
                { 
                    combo[i].SelectedItem = authname[i];
                }
                authname[i] = null;
            }
        }

        private void txtqty_TextChanged(object sender, EventArgs e)
        {
            txtid_Barcode.Clear();
            int n = 0;
            if (txtqty.Text != "")
            {
                n = int.Parse(txtqty.Text);
                if (id > 0)
                {
                    for (int i = 1; i <= n; i++)
                    {
                        id += 1;
                        if (id < 10)
                        {
                            txtid_Barcode.Text += $"{txtid.Text}000{id}\n";
                        }
                        else if (id >= 10 && id < 100)
                        {
                            txtid_Barcode.Text += $"{txtid.Text}00{i}\n";
                        }
                        else if (id >= 100 && id < 1000)
                        {
                            txtid_Barcode.Text += $"{txtid.Text}0{id}\n";
                        }
                        else
                        {
                            txtid_Barcode.Text += $"{txtid.Text}{id}\n";
                        }
                        // MessageBox.Show("If: "+i.ToString());
                    }
                }
                else
                {
                    for (int i = 1; i <= n; i++)
                    {
                        if (i < 10)
                        {
                            txtid_Barcode.Text += $"{txtid.Text}000{i}\n";
                        }
                        else if (i >= 10 && i < 100)
                        {
                            txtid_Barcode.Text += $"{txtid.Text}00{i}\n";
                        }
                        else if (i >= 100 && i < 1000)
                        {
                            txtid_Barcode.Text += $"{txtid.Text}0{i}\n";
                        }
                        else
                        {
                            txtid_Barcode.Text += $"{txtid.Text}{i}\n";
                        }
                        // MessageBox.Show("Else: "+i.ToString());
                    }
                }
            }
            else
            {
                txtid_Barcode.Clear();
            }
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txtid.Enabled == true)
            {
                Save();
            }
            else
            {
                Edit();
                this.Close();
            }
        }

        private void cmbAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select athid, lname From tbAthor Where fname=N'" + cmbAuthor1.Text + "'",con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auth[0] = dr["athid"].ToString();
                    txtSurname1.Text = dr["lname"].ToString();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dr.Close(); 
            }
        }
        private void cmbAuthor2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select athid, lname From tbAthor Where fname=N'" + cmbAuthor2.Text + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auth[1] = dr["athid"].ToString();
                    txtSurname2.Text = dr["lname"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dr.Close();
            }
        }

        private void cmbAuthor3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select athid, lname From tbAthor Where fname=N'" + cmbAuthor3.Text + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auth[2] = dr["athid"].ToString();
                    txtSurname3.Text = dr["lname"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dr.Close();
            }
        }

        private void cmbAuthor4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select athid, lname From tbAthor Where fname=N'" + cmbAuthor4.Text + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    auth[3] = dr["athid"].ToString();
                    txtSurname4.Text = dr["lname"].ToString();
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                dr.Close();
            }
        }

        private void txtid_Barcode_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void NextFocusAuthor(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void NextFocusBooks(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.SelectNextControl((Control)sender, true, true, true, true);
            }
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            //Print Barcode
            int CountLine = txtid_Barcode.Lines.Length - 1;
            string[] data = new string[CountLine];
            for (int i = 0; i < CountLine; i++)
            {
                data[i] = txtid_Barcode.Lines[i];
                PictureBox picBarCode = new PictureBox();
                BarcodeWriter barcode = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };

                picBarCode.Name = "picBar" + i;
                // MessageBox.Show(data[i]);
                picBarCode.Image = barcode.Write(data[i]);
                picBarCode.SizeMode = PictureBoxSizeMode.StretchImage;
                picBarCode.Height = 80;
                MemoryStream memo = new MemoryStream();
                picBarCode.Image.Save(memo, ImageFormat.Png);
                byte[] image = memo.ToArray();

                MyModel.table.Rows.Add(data[i], image);
            }

            //string[] data = new string[CountLine];
            //for (int i = 0; i < CountLine; i++)
            //{
            //    data[i] = txtid_Barcode.Lines[i];
            //}
            frmPrintBarcode printBarC = new frmPrintBarcode(/*data,*/MyModel.table);
            printBarC.ShowDialog();
        }

        private void txtqty_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }

        private void txtPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyNumber(e);
        }

        private void txtISBN_KeyPress(object sender, KeyPressEventArgs e)
        {
            MyModel.KeyISBN(e);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select typeid From tbType Where typename=N'" + cmbType.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    typeid = dr["typeid"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

        private void cmbCtg_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Select catgid From tbCategory Where name=N'" + cmbCtg.Text + "'", con);
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    catgid = dr["catgid"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dr.Close();
            }
        }

        private void txtid_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = MyModel.eng;
        }

        private void txtid_TextChanged(object sender, EventArgs e)
        {
            if (txtid.Enabled != false)
            {
                if (txtid.Text != "")
                {
                    MaxID();
                }
                else
                {
                    txtid_Barcode.Clear();
                }
            }
            else
            {
                cmd = new SqlCommand("Select barcode From tbBooks Where bid='" + txtid.Text + "'", con);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    txtid_Barcode.Text += dr["barcode"].ToString() + "\n";
                }
                dr.Close();
            }
        }

        private void btdel_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}