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
        private readonly CoreGbMseDbContext _context;

        public ITOController(CoreGbMseDbContext context)
        {
            _context = context;
        }

        // GET: ITO Статус пэйдж
        public ActionResult Index()
        {
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

        [HttpPost]
        public IActionResult WorkInTask(TaskWork task)
        {

            return View();
        }

    }
}