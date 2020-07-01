using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace ProjectLibrary
{
    public partial class frmReportBooksLost : Form
    {
        public frmReportBooksLost()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmReportBooksLost(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }


        SqlConnection con = MyConnected.getConnect();
        SqlDataAdapter da;
        DataTable table;
        SqlCommand cmd;
        DsBarcode ds;
        ReportDocument rd;

        private void ReportAll()
        {
            try
            {
                ds = new DsBarcode();
                ds.Clear();
                da = new SqlDataAdapter("Select * From tbBook_Lost", con);
                da.Fill(ds, "tbBook_Lost");
                rd = new ReportDocument();
                rd.Load(Application.StartupPath+"\\CrReportBookLost.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ReportByYear(int year)
        {
            try
            {
                ds = new DsBarcode();
                ds.Tables["tbBook_Lost"].Clear();
                cmd = new SqlCommand("Select barcode, bname, page, qty, cost, catgname, typename, tbdid, [date] From vw_Book_Lost_ByYear Where year_now=@year", con);
                cmd.Parameters.AddWithValue("year", DbType.Int64).Value = year;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbBook_Lost");
                rd = new ReportDocument();
                rd.Load(Application.StartupPath+"\\CrReportBookLost.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }  
       
        private void ReportByMonth(int month)
        {
            try
            {
                ds = new DsBarcode();
                ds.Tables["tbBook_Lost"].Clear();
                cmd = new SqlCommand("Select barcode, bname, page, qty, cost, catgname, typename, tbdid, [date] from vw_Book_Lost_ByMonth Where month_now=@month", con);
                cmd.Parameters.AddWithValue("month", DbType.Int64).Value = month;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbBook_Lost");
                rd = new ReportDocument();
                rd.Load(Application.StartupPath+"\\CrReportBookLost.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ReportByDate(DateTime date1, DateTime date2)
        {
            try
            {
                ds = new DsBarcode();
                ds.Tables["tbBook_Lost"].Clear();
                cmd = new SqlCommand("Select * From tbBook_Lost Where [date] Between @date1 And @date2", con);
                cmd.Parameters.AddWithValue("date1", DbType.Date).Value = date1.Date;
                cmd.Parameters.AddWithValue("date2", DbType.Date).Value = date2.Date;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbBook_Lost");
                rd = new ReportDocument();
                rd.Load(Application.StartupPath+"\\CrReportBookLost.rpt");
                rd.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtShearch_TextChanged(object sender, EventArgs e)
        {
            //crtReportBooksLost crt = new crtReportBooksLost();
            //TextObject txtob=(TextObject)crt.ReportDefinition.Sections["Section3"].ReportObjects["txtShearch"]
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbYear.Checked == true)
            {
                cbMouth.Checked = false;
                ReportByYear(DateTime.Now.Year);
            }
            else if(cbYear.Checked==false && cbMouth.Checked==false)
            {
                ReportAll();
            }
        }

        private void cbMouth_CheckedChanged(object sender, EventArgs e)
        {
            if (cbMouth.Checked == true)
            {
                cbYear.Checked = false;
                ReportByMonth(DateTime.Now.Month);
            }
            else if (cbYear.Checked == false && cbMouth.Checked == false)
            {
                ReportAll();
            }
        }

        private void frmReportBooksLost_Load(object sender, EventArgs e)
        {
            ReportAll();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            ReportByDate(dateSt.Value, dateEn.Value);
        }
    }
}
