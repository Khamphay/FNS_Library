using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;
using ZXing;
using CrystalDecisions.CrystalReports.Engine;
using ProjectLibrary.Report;

namespace ProjectLibrary
{
    public partial class frmPrintBarcode : Form
    {
        public frmPrintBarcode()
        {
            InitializeComponent();
        }

        //DataTable table;
        CRBarcode crBarcode = new CRBarcode();
        //Construtor
        public frmPrintBarcode(/*string[] data,*/ DataTable table)
        {
            InitializeComponent();

            crBarcode.SetDataSource(table);
            crystalReportViewer1.ReportSource = crBarcode;
        }

        Bitmap bm;
        public void PrintPreview()
        {
            try
            {
                //prPvD: PrintPreviewDialog
                //prDm: PrintDocument

                //PrintArea(flbShowBarC);
                //prPvD.Document = prDm;
                //prDm.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prDm_PrintPage);
                //prPvD.ShowDialog();
            }
            catch (Exception ex)
            {
                
            }
        }

        public void PrintArea(FlowLayoutPanel pnl)
        {
            //bm = new Bitmap(pnl.Width, pnl.Height);
            //pnl.DrawToBitmap(bm, new Rectangle(10, 0, pnl.Width, pnl.Height));
        }

        private void prDm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            //Rectangle rt = e.PageBounds;
            //e.Graphics.DrawImage(bm, (rt.Width / 2) - (flbShowBarC.Width / 2), this.Location.Y);
        }

        private void frmPrintBarcode_Load(object sender, EventArgs e)
        {
        }

        private void gunaAdvenceButton1_Click(object sender, EventArgs e)
        {
            PrintPreview();
            this.Close();
        }

        private void frmPrintBarcode_FormClosed(object sender, FormClosedEventArgs e)
        {
            MyModel.table.Rows.Clear();
        }
    }
}
