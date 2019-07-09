using CoreGbMSE.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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


        public IActionResult ListZayavka() => View(_context.TaskWork.Include(x => x.Otdel).ToListAsync());


    }
}