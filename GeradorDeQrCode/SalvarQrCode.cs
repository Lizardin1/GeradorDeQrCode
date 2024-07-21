using PdfSharp.Drawing;
using PdfSharp.Pdf;
using System.Drawing.Imaging;

namespace GeradorDeQrCode
{
    public class SalvarQrCode
    {
        public static void SaveQrCodePng(Image img, string filePath)
        {
            img.Save(filePath, ImageFormat.Png);
        }



        public static void SavePdf(Image img, string filePath)
        {
            PdfDocument document = new PdfDocument();
            document.Info.Title = "Imagem como PDF";

            PdfPage page = document.AddPage();
            page.Width = XUnit.FromPoint(500);
            page.Height = XUnit.FromPoint(500);

            XGraphics gfx = XGraphics.FromPdfPage(page);

            using (var ms = new System.IO.MemoryStream())
            {
                img.Save(ms, ImageFormat.Png);
                XImage image = XImage.FromStream(ms);
                gfx.DrawImage(image, 0, 0, page.Width, page.Height);
            }

            document.Save(filePath);
        }
    }
}
