using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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
        public async Task<IActionResult> Index()
        {
            var students = await _context.Students.ToListAsync();

            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("StudentName, StudentEmail, StudentPhone")] Student student)
        {
            if (ModelState.IsValid)
            {
                // Save the student to the database
                _context.Add(student);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(student);
        }

    }
}
