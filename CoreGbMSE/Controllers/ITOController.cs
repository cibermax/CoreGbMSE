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


        public async Task<IActionResult> ListZayavka()
        {
            return View(await  _context.TaskWork.Include(x=>x.Otdel).Include(z=>z.TaskType).ToListAsync());
        }


    }
}