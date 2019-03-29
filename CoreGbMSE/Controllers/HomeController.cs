using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CoreGbMSE.Models;
using CoreGbMSE.Data;

namespace CoreGbMSE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ZayavkaItoAdd()
        {

            return View();
        }

        [HttpPost]
        public IActionResult ZayavkaItoAdd(TaskWork Task)
        {
            return View();
        }


        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // GET: Filials/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Filials/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Filial model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    

                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }
    }
}
