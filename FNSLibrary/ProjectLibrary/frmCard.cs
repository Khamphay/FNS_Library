using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using Guna.UI.WinForms;
using System.Globalization;

namespace ProjectLibrary
{
    public partial class frmCard : Form
    {
        public frmCard()
        {
            InitializeComponent();
        }
        public frmCard(string[] info)
        {
            InitializeComponent();

            lbMemberID.Text = info[0];
            lbName.Text = $"{info[1]} {info[2]}";
            lbBirdDate.Text = info[3];
            lbDateNow.Text = info[4];
            year = DateTime.ParseExact(info[5], "dd-MM-yyyy", CultureInfo.InvariantCulture);
            lbDateExip.Text = year.ToString("dd-MM-yyyy");
            lbFirtYear.Text = year.AddYears(-4).ToString("yyyy") + "-" + year.AddYears(-3).ToString("yyyy");
            lbSccordYear.Text = year.AddYears(-3).ToString("yyyy") + "-" + year.AddYears(-2).ToString("yyyy");
            lbThirdYear.Text = year.AddYears(-2).ToString("yyyy") + "-" + year.AddYears(-1).ToString("yyyy");
            lbFourYear.Text = year.AddYears(-1).ToString("yyyy") + "-" + year.AddYears(0).ToString("yyyy");
        }

        DateTime year;
        Bitmap bm;
        private void PrintCard()
        {

            //prPvD: PrintPreviewDialog
            //prDcm: PrintDocument

            try
            {
                PrintArea(pnCard);
                prPvD.Document = prDcm;
                prDcm.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(prDcm_PrintPage); 
                prPvD.ShowDialog();
            }catch (Exception ex)
            {

            }
        }
        private void PrintArea(GunaGradientPanel pnl)
        {
            bm = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(bm, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }
        private void frmCard_Load(object sender, EventArgs e)
        {
            try
            {
                BarcodeWriter barcode = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };
                picBarcode.Image = barcode.Write(lbMemberID.Text);
            }catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void prDcm_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle rtg = e.PageBounds;
            e.Graphics.DrawImage(bm,(rtg.Width/2)-(pnCard.Width/2), pnCard.Location.Y);
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            PrintCard();
        }
    }
}
