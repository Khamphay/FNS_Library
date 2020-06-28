using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace ProjectLibrary
{
    public partial class frmPrintMemberCard : Form
    {
        public frmPrintMemberCard( DataTable cartable)
        {
            InitializeComponent();
            rd.Load("C:\\Users\\Khamphay Muas\\Documents\\Libary\\FNSLibrary\\ProjectLibrary\\CrMemberCard.rpt");
            rd.SetDataSource(cartable);
        }

        ReportDocument rd=new ReportDocument();

        private void frmShowRentBooks_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = rd;
            crystalReportViewer1.Refresh();
        }
    }
}
