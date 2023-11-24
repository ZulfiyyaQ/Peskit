using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peskit.DAL;

namespace Peskit.Controllers
{
    public class BlogsController : Controller
    {
        private readonly AppDbContext _context;


        public BlogsController(AppDbContext context)
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
