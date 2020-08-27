using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using Microsoft.Reporting.WebForms;
using ProjectLibrary.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLibrary.FormShow.BooksInformation
{
    public partial class frmReportBooks : Form
    {
        Form1 _home;
        public frmReportBooks(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }
        SqlConnection con = MyConnected.getConnect();
        SqlCommand cmd;
        SqlDataAdapter da;
        DsBarcode ds;
        crReportBooks_Book crBooks;
        ParameterDiscreteValue discreteValue =new ParameterDiscreteValue();
        ParameterFieldDefinition fieldDefinition;
        ParameterFieldDefinitions fieldDefinitions;
        ParameterValues parameterValues = new ParameterValues();

        private void Report()
        {
            try
            {
                if (rdbReserve.Checked == true)
                {
                    cmd = new SqlCommand("Select * From vw_Book Where status=N'ກຳລັງຈອງ'", con);
                }else if (rdbRent.Checked == true)
                {
                    cmd = new SqlCommand("Select * From vw_Book Where status=N'ກຳລັງຢືມ'", con);
                }
                else
                {
                    cmd = new SqlCommand("Select * From vw_Book", con);
                }
                da = new SqlDataAdapter(cmd);
                ds = new DsBarcode();
                da.Fill(ds, "vw_Book");

                crBooks = new crReportBooks_Book();
                crBooks.SetDataSource(ds);

                //Pass staff id
                discreteValue.Value = MyModel.staff[0];
                fieldDefinitions = crBooks.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["staff_id"];
                parameterValues = fieldDefinition.CurrentValues;

                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Pass staff name
                discreteValue.Value = MyModel.staff[1] + " " + MyModel.staff[2];
                fieldDefinitions = crBooks.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["name"];
                parameterValues = fieldDefinition.CurrentValues;

                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Pass staff tel
                discreteValue.Value = MyModel.staff[3];
                fieldDefinitions = crBooks.DataDefinition.ParameterFields;
                fieldDefinition = fieldDefinitions["tel"];
                parameterValues = fieldDefinition.CurrentValues;

                parameterValues.Clear();
                parameterValues.Add(discreteValue);
                fieldDefinition.ApplyCurrentValues(parameterValues);

                //Show Report
                crystalReportViewer1.ReportSource = crBooks;
                crystalReportViewer1.Refresh();


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            Report();
        }

        private void gunaGroupBox1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void btExit_Click_1(object sender, EventArgs e)
        {
            _home.ShowHomePage();
        }

        private void frmReportBooks_Load(object sender, EventArgs e)
        {
            Report();
        }
    }
}
