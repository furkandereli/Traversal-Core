using BusinessLayer.Abstract;
using ClosedXML.Excel;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using TraversalCore.Models;

namespace TraversalCore.Controllers
{
    [AllowAnonymous]
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;
        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public List<DestinationModel> destinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>();
            using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    city = x.city,
                    dayNight = x.dayNight,
                    price = x.price,
                    capacity = x.capacity
                }).ToList();
            }
            return destinationModels;
        }
        
        public IActionResult StaticExcelReport()
        {
            return File(_excelService.excelList(destinationList()), "application/vnd.openxmlformats-officedocument.spreedsheetml.sheet",
                "YeniExcel.xlsx");
        }

        public IActionResult DestinationExcelReport()
        {
            using(var workBook = new XLWorkbook())
            {
                var workSheet = workBook.Worksheets.Add("Tur Listesi");
                workSheet.Cell(1, 1).Value = "Şehir";
                workSheet.Cell(1, 2).Value = "Konaklama Süresi";
                workSheet.Cell(1, 3).Value = "Fiyat";
                workSheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach(var item in destinationList())
                {
                    workSheet.Cell(rowCount, 1).Value = item.city;
                    workSheet.Cell(rowCount, 2).Value = item.dayNight;
                    workSheet.Cell(rowCount, 3).Value = item.price;
                    workSheet.Cell(rowCount, 4).Value = item.capacity;
                    rowCount++;

                }

                using(var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreedsheetml.sheet", "YeniListe.xlsx");
                }
            }
        }
    }
}
