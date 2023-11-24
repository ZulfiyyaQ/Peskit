using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Peskit.Areas.Admin.Controllers
{
    public class PositionsController : Controller
    {
        // GET: PositionsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PositionsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PositionsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PositionsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: PositionsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PositionsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: PositionsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PositionsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
    }
}
