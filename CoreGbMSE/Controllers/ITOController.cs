using Microsoft.AspNetCore.Mvc;

namespace CoreGbMSE.Controllers
{
    public class ITOController : Controller
    {
        // GET: ITO Статус пэйдж
        public ActionResult Index()
        {
            return View();
        }
    }
}