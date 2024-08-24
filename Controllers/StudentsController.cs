using Microsoft.AspNetCore.Mvc;

namespace StudentController.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Delete()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        public IActionResult GetAll()
        {
            return View();
        }
        public IActionResult Update()
        {
            return View();
        }

    }
}
