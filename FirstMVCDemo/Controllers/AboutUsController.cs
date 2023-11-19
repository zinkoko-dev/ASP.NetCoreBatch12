using Microsoft.AspNetCore.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class AboutUsController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public AboutUsController(IWebHostEnvironment webHostEnvironment)
        {
            this._webHostEnvironment = webHostEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CalculateSum(int n1, int n2)
        {
            int result = n1 + n2;
            ViewBag.Sum = result;
            return View();
        }

        public IActionResult SimpleDownload()
        {
            string fileName = "grade1-bounce-support-1.png";
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "downloadfile//" + fileName);
            byte[] fileInBytes = System.IO.File.ReadAllBytes(filePath);
            return File(fileInBytes, "text/png", fileName);
        }

        [HttpPost]
        public IActionResult TellMeYourFullName(string firstName, string lastName)
        {
            string fullName = $"Hello, {firstName} {lastName}, Welcome !!";
            ViewBag.Result = fullName;
            return View();
        }
    }
}
