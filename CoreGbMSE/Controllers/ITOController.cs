using CoreGbMSE.Data;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

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


        public ActionResult ListZayavka()
        {
            return View(_context.TaskWork.ToList());
        }


    }
}