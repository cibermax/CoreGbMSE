using System.Linq;
using CoreGbMSE.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CoreGbMSE.Controllers
{

    public class FilialsController : Controller
    {
        private readonly CoreGbMseDbContext _context;


        public FilialsController(CoreGbMseDbContext context)
        {
            _context = context;
        }

        // GET: Filials
        public ActionResult Index()
        {
            return View(_context.Filials.ToList());
        }

        // GET: Filials/Details/5
        public ActionResult Details(int id)
        {
            return View(_context.Filials.Single(x=>x.FilialId==id));
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
                if(ModelState.IsValid)
                {

            
                   ////65789908765
                    _context.Filials.Add(model);
                    _context.SaveChanges();
                }

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error");
            }
        }

        // GET: Filials/Edit/5
        public ActionResult Edit(int id)
        {
            return View(_context.Filials.Single(x => x.FilialId == id));
        }

        // POST: Filials/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Filial model)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    _context.Entry(model).State = EntityState.Modified;
                    _context.SaveChanges();

                }


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Filials/Delete/5
        public ActionResult Delete(int id)
        {
            return View(_context.Filials.Single(x => x.FilialId == id));
        }

        // POST: Filials/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection formCollection)
        {
            try
            {
                // TODO: Add delete logic here

                _context.Entry(_context.Filials.Single(x => x.FilialId == id)).State = EntityState.Deleted;
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}