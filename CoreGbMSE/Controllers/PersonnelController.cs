using CoreGbMSE.Data;
using CoreGbMSE.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreGbMSE.Controllers
{
    public class PersonnelController : Controller
    {
        private readonly CmsDbContext _context;

        public PersonnelController(CmsDbContext context)
        {
            _context = context;
        }

        // GET: Personnel
        public ActionResult Index()
        {
            return View(_context.Personnels);
        }

        // GET: Personnel/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.Personnels.Find(id));
        }

        // GET: Personnel/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Personnel/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Personnel model)
        {
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _context.Personnels.Add(model);
                    _context.SaveChanges();
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personnel/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.Personnels.Find(id));
        }

        // POST: Personnel/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Personnel model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _context.Personnels.Update(model);
                    _context.SaveChanges();
                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Personnel/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Personnel/Delete/5
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