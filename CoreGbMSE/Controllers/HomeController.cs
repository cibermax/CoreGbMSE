using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using CoreGbMSE.Models;
using CoreGbMSE.Data;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace CoreGbMSE.Controllers
{
    public class HomeController : Controller
    {
        private readonly CoreGbMseDbContext _context;

        public HomeController(CoreGbMseDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult ZayavkaItoAdd()
        {
            ViewBag.otdels = new SelectList(_context.Otdels, "OtdelId", "Name");
            ViewBag.taskType = new SelectList(_context.TaskType, "TaskTypeId", "Name");

            return View();
        }

        [HttpPost]
        public IActionResult ZayavkaItoAdd(TaskWork Task)
        {
            ViewBag.otdels = new SelectList(_context.Otdels, "OtdelId", "Name");
            ViewBag.taskType = new SelectList(_context.TaskType, "TaskTypeId", "Name");
            Task.DateAdd = DateTime.Now;

            Task.Otdel = _context.Otdels.Where(x => x.OtdelId == Task.Otdel.OtdelId).Single();
            Task.TaskType = _context.TaskType.Where(x => x.TaskTypeId == Task.TaskType.TaskTypeId).Single();

            //if (ModelState.IsValid)
            //{

            Task.Status = Status.New;
            _context.TaskWork.Add(Task);
            _context.SaveChanges();
            //}

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


        public IActionResult Succes()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}
