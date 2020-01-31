using CoreGbMSE.Data;
using CoreGbMSE.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace CoreGbMSE.Controllers
{
    public class ITOController : Controller
    {
        private readonly CmsDbContext _context;

        public ITOController(CmsDbContext context)
        {
            _context = context;
        }

        // GET: ITO Статус пэйдж
        public ActionResult Index()
        {
            ViewBag.AllTask = _context.TaskWork.ToList().Count;

            ViewBag.AllFinishTask = _context.TaskWork.Where(x => x.Status == Status.Finish).Count();


            DateTime dnow = DateTime.Now;
            DateTime first = new DateTime(dnow.Year, dnow.Month, 1);
            DateTime last = new DateTime(dnow.Year, dnow.Month + 1, 1).AddDays(-1);
            ViewBag.CurrentMontAllTask = _context.TaskWork.Where(x => x.DateAdd >= first).Count();

            ViewBag.CurrentMontFinishTask = _context.TaskWork.Where(x => x.DateAdd >= first).Where(z=>z.Status==Status.Finish).Count();


            return View();
        }


        public async Task<IActionResult> ListZayavka()
        {
            return View(await  _context.TaskWork.OrderBy(x=>x.DateAdd).Include(x=>x.Otdel).Include(z=>z.TaskType).ToListAsync());
        }

        //[Route("DetailTask/{id:int}")]
        public async Task<IActionResult> DetailTask(int id)
        {
            return View(await _context.TaskWork.Where(x => x.TaskWorkId == id).Include(z => z.Otdel).Include(y => y.TaskType).SingleAsync());
        }

        public  IActionResult FinishTask(int id)
        {
            var task = _context.TaskWork.Where(x => x.TaskWorkId == id).Single();
            task.DateFinish = DateTime.Now;
            task.Status = Models.Status.Finish;

            _context.Update(task);
            _context.SaveChanges();

            return RedirectToAction("ListZayavka");
        }

        public IActionResult CancelTask(int id)
        {
            var task = _context.TaskWork.Where(x => x.TaskWorkId == id).Single();
            //task.DateFinish = DateTime.Now;
            task.Status = Models.Status.Cancel;

            _context.Update(task);
            _context.SaveChanges();

            return RedirectToAction("ListZayavka");
        }

        [Route("WorkInTask/{id:int}")]
        public async Task<IActionResult> WorkInTaskAsync(int id)
        {
            return View(await _context.TaskWork.Where(x => x.TaskWorkId == id).Include(z => z.Otdel).Include(y => y.TaskType).SingleAsync());
        }

        
        public IActionResult WorkInTask(int id)
        {
            var tmptask = _context.TaskWork.Where(x => x.TaskWorkId == id).Single();
            //task.DateFinish = DateTime.Now;
            tmptask.Status = Status.Working;

            _context.Update(tmptask);
            _context.SaveChanges();

            return RedirectToAction("ListZayavka");
            //return View();
        }

    }
}