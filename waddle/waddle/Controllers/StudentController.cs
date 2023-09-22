using Microsoft.AspNetCore.Mvc;
using waddle.Data;

namespace waddle.Controllers
{
    public class StudentController : Controller
    {
        private readonly ApplicationContext _context;

        public StudentController(ApplicationContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


    }
}
