using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace ProjectLibrary
{
    public partial class frmReportMember : Form
    {
        public frmReportMember()
        {
            InitializeComponent();
        }

        Form1 _home;
        public frmReportMember(Form1 home)
        {
            InitializeComponent();
            _home = home;
        }

        SqlConnection con = MyConnected.getConnect();
        SqlDataAdapter da;
        SqlCommand cmd;
        DsBarcode ds;
        ReportDocument crd;

        private void Reprot_All_Member()
        {
            ds = new DsBarcode();
            ds.Clear();
            if (rdbAllCard.Checked == true || rdbExpireCard.Checked!=true)
            {
                cmd = new SqlCommand("Select * From tbMember", con);
                cmd.ExecuteNonQuery();
            }else if (rdbExpireCard.Checked == true)
            {
                cmd = new SqlCommand("Select * From tbMember Where dateREd<@dateNow", con);
                cmd.Parameters.AddWithValue("dateNow", DbType.Date).Value = DateTime.Now;
                cmd.ExecuteNonQuery();
            }
            da = new SqlDataAdapter(cmd);
            da.Fill(ds, "tbMember");
            crd= new ReportDocument();
            crd.Load(@"C:\Users\Khamphay Muas\Documents\GitHub\FNS_Library\FNSLibrary\ProjectLibrary\CrReportMember.rpt");
            crd.SetDataSource(ds);
            crystalReportViewer1.ReportSource = crd;
            crystalReportViewer1.Refresh();

        }

        private void rdbAllCard_CheckedChanged(object sender, EventArgs e)
        {
            Reprot_All_Member();
        }

        private void rdbExpireCard_CheckedChanged(object sender, EventArgs e)
        {
            Reprot_All_Member();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();
            _home.ShowHomePage();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            _home.Clear_PanelMenu();
        }

        private void frmReportMember_Load(object sender, EventArgs e)
        {
            Reprot_All_Member();
        }
    }
}
