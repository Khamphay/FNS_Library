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

        //Use for Pass parameter(Staff infor) to report
        ParameterFieldDefinitions fieldDefinitions;
        ParameterFieldDefinition fieldDefinition;
        ParameterValues parameterValues = new ParameterValues();
        ParameterDiscreteValue discreteValue = new ParameterDiscreteValue();

        private void Report()
        {
            try
            {
                ds = new DsBarcode();
                ds.Tables["tbBook_Lost"].Clear();
                if (cbYear.Checked == true)
                {
                    cmd = new SqlCommand("Select * From vw_BookLost Where Year([date])=@year", con);
                    cmd.Parameters.AddWithValue("year", DbType.Int64).Value = DateTime.Now.Year;
                }else if (cbMouth.Checked == true)
                {
                    cmd = new SqlCommand("Select * From vw_BookLost Where Month([date]) =@year", con);
                    cmd.Parameters.AddWithValue("year", DbType.Int64).Value = DateTime.Now.Month;
                }
                else
                {
                    cmd = new SqlCommand("Select * From vw_BookLost", con);
                }
                
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbBook_Lost");
                rd = new ReportDocument();
                rd.Load(Application.StartupPath+"\\CrReportBookLost.rpt");
                rd.SetDataSource(ds);

                //Pass staff id
                discreteValue.Value = MyModel.staff[0];
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["staff_id"];
                parameterValues = fieldDefinition.CurrentValues;

                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Pass staff name
                discreteValue.Value = MyModel.staff[1] + " " + MyModel.staff[2];
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["name"];
                parameterValues = fieldDefinition.CurrentValues;

                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Pass staff tel
                discreteValue.Value = MyModel.staff[3];
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["tel"];
                parameterValues = fieldDefinition.CurrentValues;

                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Show Report
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
                cmd = new SqlCommand("Select * From vw_BookLost Where [date] Between @date1 And @date2", con);
                cmd.Parameters.AddWithValue("date1", DbType.Date).Value = date1.Date;
                cmd.Parameters.AddWithValue("date2", DbType.Date).Value = date2.Date;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds, "tbBook_Lost");
                rd = new ReportDocument();
                rd.Load(Application.StartupPath+"\\CrReportBookLost.rpt");
                rd.SetDataSource(ds);

                //Pass staff id
                discreteValue.Value = MyModel.staff[0];
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["staff_id"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Pass staff name
                discreteValue.Value = MyModel.staff[1] + " " + MyModel.staff[2];
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["name"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Pass staff tel
                discreteValue.Value = MyModel.staff[3];
                fieldDefinitions = rd.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["tel"];
                parameterValues = fieldDefinition.CurrentValues;
                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);


                crystalReportViewer1.ReportSource = rd;
                crystalReportViewer1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
            Report();
        }

        private void cbMouth_CheckedChanged(object sender, EventArgs e)
        {
            Report();
        }

        private void frmReportBooksLost_Load(object sender, EventArgs e)
        {
            Report();
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            ReportByDate(dateSt.Value, dateEn.Value);
        }
    }
}
