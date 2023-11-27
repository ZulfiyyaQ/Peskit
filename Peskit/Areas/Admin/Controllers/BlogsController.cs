using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Peskit.Areas.Admin.Controllers;
[Area("Admin")]
public class BlogsController : Controller
{
    
    public ActionResult Index()
    {
        return View();
    }

  

    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    
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
