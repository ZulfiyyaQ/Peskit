using Azure;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Peskit.DAL;
using Peskit.Models;

namespace Peskit.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AuthorsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public AuthorsController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task< IActionResult> Index()
        {
            List<Author> authors = await _context.Authors.ToListAsync();
            return View();
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Author author)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool result = _context.Authors.Include(b=>b.Blogs).Any(a => a.Name.ToLower().Trim() == author.Name.ToLower().Trim());
            if (result)
            {
                ModelState.AddModelError("Name", "Tag already exists");
                return View();
            }
            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
        public ActionResult Update(int id)
        {
            return View();
        }


        [HttpPost]

        public ActionResult Update(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(int id)
        {
            return View();
        }

        [HttpPost]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        public ActionResult Details(int id)
        {
            return View();
        }




    }
}
