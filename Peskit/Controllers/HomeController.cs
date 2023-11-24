using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Peskit.DAL;

namespace Peskit.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;


        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

       
    }
}
