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

namespace ProjectLibrary
{
    public partial class frmPrintBarcode : Form
    {
        public frmPrintBarcode()
        {
            InitializeComponent();
        }

        //DataTable table;
        ReportDocument cryDm = new ReportDocument();
        //Construtor
        public frmPrintBarcode(/*string[] data,*/ DataTable table)
        {
            InitializeComponent();

            //table = new DataTable();
            //table.TableName = "dtBarcode";
            //table.Columns.Add("Barcode", typeof(string));
            //table.Columns.Add("Image", typeof(Byte[]));

            //if (data.Length>0)
            //{
                //#1=======
                // Print Barcode
                //for (int i = 0; i < data.Length; i++)
                //{
                //    //table = new DataTable();
                //    table.Rows.Add(data[i]);
                //}
                //cryDm.Load("D:\\FNSLibrary\\ProjectLibrary\\CRBarcode.rpt");
                //cryDm.SetDataSource(table);
                //crystalReportViewer1.ReportSource = cryDm;

                //#2=====
                // PictureBox[] picBC = new PictureBox[4];
                //for (int i = 0; i < data.Length; i++)
                //{
                    //PictureBox picBarCode = new PictureBox();
                    //BarcodeWriter barcode = new BarcodeWriter() { Format = BarcodeFormat.CODE_128 };

                    //picBarCode.Name = "picBar" + i;
                    //// MessageBox.Show(data[i]);
                    //picBarCode.Image = barcode.Write(data[i]);
                    //picBarCode.SizeMode = PictureBoxSizeMode.StretchImage;
                    //picBarCode.Height = 80;
                    ////#2.1=====
                    ////flbShowBarC.Controls.Add(picBarCode);

                    ////#2.2=====
                    //MemoryStream memo = new MemoryStream();
                    //picBarCode.Image.Save(memo, ImageFormat.Png);
                    //byte[] image = memo.ToArray();

                    //table.Rows.Add(data[i], image);
                //}
                cryDm.Load(Application.StartupPath+"\\CRBarcode.rpt");
                cryDm.SetDataSource(table);
                crystalReportViewer1.ReportSource = cryDm;
            //}
            //else
            //{
            //    //Label lb = new Label();
                //lb.Text = "* ບໍ່ມີຂໍ້ມູນ *";
                //lb.Width = 200;
                //lb.Height = 40;
                //flbShowBarC.Controls.Add(lb);
            //}
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
