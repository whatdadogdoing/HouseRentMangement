using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using DevExpress.CodeParser;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Rectangle = System.Drawing.Rectangle;

namespace HouseRentManagement
{
    
    public partial class ExportAdmin : Form
    {
        private ChildFormManager fformManeger = new ChildFormManager();
        public ExportAdmin()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            ShowReportCondoForm();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ShowReportFeeForm();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ShowReportServiceForm();
        }
        private void ShowReportCondoForm()
        {
            if (fformManeger.CurrentChildForm is ReportRoomResidenceAdmin)
            {
                return;
            }
            fformManeger.CloseCurrentChildForm();
            ReportRoomResidenceAdmin ra = new ReportRoomResidenceAdmin();
            fformManeger.ShowChildForm(pnlExport, ra);
        }
        public void ShowReportFeeForm()
        {
            if (fformManeger.CurrentChildForm is ReportMoneyAdmin)
            {
                return;
            }
            fformManeger.CloseCurrentChildForm();
            ReportMoneyAdmin ra = new ReportMoneyAdmin();
            fformManeger.ShowChildForm(pnlExport, ra);
        }
        private void ShowReportServiceForm()
        {
            if (fformManeger.CurrentChildForm is ReportServiceAdmin)
            {
                return;
            }
            fformManeger.CloseCurrentChildForm();
            ReportServiceAdmin ra = new ReportServiceAdmin();
            fformManeger.ShowChildForm(pnlExport, ra);
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {
            string Path = "D:/Report1.pdf";
            PrintPanelToPDF(pnlExport,Path);
        }
        private void PrintPanelToPDF(Control panel, string filePath)
        {

            { //Sử dụng iTextSharp
                using (Document pdfDoc = new Document())
                {
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, new FileStream(filePath, FileMode.Create));

                    pdfDoc.Open();

                    // Lấy PdfContentByte thông qua PdfWriter
                    PdfContentByte cb = writer.DirectContent;

                    //Lấy kích thước panel
                    SizeF panelSize = panel.Size;

                    // Vẽ panel lên trang pdf  
                    Bitmap bmp = new Bitmap((int)panelSize.Width, (int)panelSize.Height);
                    panel.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                    MemoryStream ms = new MemoryStream();
                    bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    ms.Position = 0;

                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(ms);

                    image.ScalePercent(50f);
                    image.SetAbsolutePosition(0, pdfDoc.PageSize.Height - image.ScaledHeight);

                    // Sử dụng PdfContentByte đã lấy từ PdfWriter
                    cb.AddImage(image);

                    pdfDoc.Close();
                    MessageBox.Show("Printed Successfully");
                }
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
