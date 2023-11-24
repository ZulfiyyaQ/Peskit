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
        public async Task<IActionResult> Create(CreateSlideVM slidevm)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!slidevm.Photo.ValidateType())
            {
                ModelState.AddModelError("Photo", "Sekil file secmeyiniz mutleqdir");
                return View();
            }
            if (!slidevm.Photo.ValidateSize(2 * 1024))
            {
                ModelState.AddModelError("Photo", "Sekil olcusu 2 mb dan artiq olmamalidir");
                return View();
            }


            string filename = await slidevm.Photo.CreateFile(_env.WebRootPath, "assets", "images", "website-images");
            Slide slide = new Slide
            {
                ImageUrl = filename,
                Title = slidevm.Title,
                Subtitle = slidevm.Subtitle,
                Description = slidevm.Description,
                Order = slidevm.Order
            };

            await _context.Slides.AddAsync(slide);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }


       


    }
}
