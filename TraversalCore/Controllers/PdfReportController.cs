using iTextSharp.text;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "dosya1.pdf");
            var stream = new FileStream(path,FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document,stream);

            document.Open();
            Paragraph paragraf = new Paragraph("Traversal Rezervasyon Pdf Raporu");
            document.Add(paragraf);
            document.Close();
            return File("/PdfReports/dosya1.pdf", "application/pdf", "dosya1.pdf");
        }
        
        public IActionResult StaticCustomerReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/PdfReports/" + "pdfdosyası.pdf");
            var stream = new FileStream(path, FileMode.Create);

            Document document = new Document(PageSize.A4);
            PdfWriter.GetInstance(document, stream);

            document.Open();
            PdfPTable pdfTable = new PdfPTable(3);
            pdfTable.AddCell("Misafir Adı");
            pdfTable.AddCell("Misafir Soyadı");
            pdfTable.AddCell("Misafir T.C.");

            pdfTable.AddCell("Eylül");
            pdfTable.AddCell("Yüce");
            pdfTable.AddCell("12345678901");

            pdfTable.AddCell("Kemal");
            pdfTable.AddCell("Yılmaz");
            pdfTable.AddCell("14752986147");

            pdfTable.AddCell("Ömer");
            pdfTable.AddCell("Tuncer");
            pdfTable.AddCell("12764825798");

            document.Add(pdfTable);

            document.Close();
            return File("/PdfReports/pdfdosyası.pdf", "application/pdf", "pdfdosyası.pdf");
        }
    }
}
