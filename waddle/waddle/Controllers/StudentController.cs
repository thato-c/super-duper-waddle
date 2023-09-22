using Microsoft.AspNetCore.Mvc;
using waddle.Data;
using waddle.Models;
using waddle.viewModels;

namespace waddle.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationContext _context;

        public StudentController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _context.Students;

            return View(students);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return PartialView("_StudentRow", student);
            }

            return PartialView("_StudentForm", student);
        }
    }
}
