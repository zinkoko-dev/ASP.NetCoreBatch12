using FirstMVCDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstMVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        IList<StudentModel> students = new List<StudentModel>();

        [HttpPost]
        public IActionResult Register(StudentModel studentModel)
        {
            students.Add(new StudentModel
            {
                FirstName = studentModel.FirstName,
                LastName = studentModel.LastName,
                DOB = studentModel.DOB,
                Address = studentModel.Address
            });

            TempData["Info"] = "Student register successful";
            return View("Index");
        }
    }
}
