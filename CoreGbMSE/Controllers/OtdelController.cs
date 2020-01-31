using System.Linq;
using CoreGbMSE.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreGbMSE.Controllers
{
    public class OtdelController : Controller
    {
        private readonly CmsDbContext _context;

        public OtdelController(CmsDbContext context)
        {
            _context = context;
        }

        // GET: Otdel
        public ActionResult Index()
        {
            return View(_context.Otdels.ToList());
        }

        // GET: Otdel/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Otdel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Otdel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Otdel/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Otdel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Otdel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Otdel/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}