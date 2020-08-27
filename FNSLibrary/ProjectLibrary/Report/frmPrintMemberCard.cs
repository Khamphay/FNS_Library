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
using ProjectLibrary.Report;

namespace ProjectLibrary
{
    public partial class frmPrintMemberCard : Form
    {
        public frmPrintMemberCard( DataTable cartable)
        {
            InitializeComponent();
            crCard.SetDataSource(cartable);
        }

        CrMemberCard crCard = new CrMemberCard();

        private void frmShowRentBooks_Load(object sender, EventArgs e)
        {
            crystalReportViewer1.ReportSource = crCard;
            crystalReportViewer1.Refresh();
        }

        private void frmPrintMemberCard_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyModel.tablecard.Rows.Clear();
        }
    }
}
