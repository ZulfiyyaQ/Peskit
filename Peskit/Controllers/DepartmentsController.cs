using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peskit.DAL;

namespace Peskit.Controllers
{
    public class DepartmentsController : Controller
    {
        private readonly AppDbContext _context;


        public DepartmentsController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details(int id)
        {
            return View();
        }

       
    }
}
