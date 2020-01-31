using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Администратор,Редактор,Оператор")] // Тестовая чисто залогининым пользователям а надо ззаменить на роли
    public class HomeController : Controller
    {
        public HomeController(RoleManager<IdentityRole> roleManager)
        {
            RoleManager = roleManager;
        }

        public IActionResult Index()
        {
            InitializeRoles(); ////////////// ЗАКОМЕНТИРОВАТЬ ПОСЛЕ СОЗДАНИЯ РОЛЕЙ

            return View();
        }

        public RoleManager<IdentityRole> RoleManager { get; }

        private async void InitializeRoles()
        {
            bool x = await RoleManager.RoleExistsAsync("Администратор");
            if (!x)
            {
                // Сначала создаем роль админа  
                var role = new IdentityRole {Name = "Администратор"};
                await RoleManager.CreateAsync(role);
            }

            // creating Creating Manager role     
            x = await RoleManager.RoleExistsAsync("Редактор");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Редактор";
                await RoleManager.CreateAsync(role);
            }

            // creating Creating Employee role     
            x = await RoleManager.RoleExistsAsync("Оператор");
            if (!x)
            {
                var role = new IdentityRole();
                role.Name = "Оператор";
                await RoleManager.CreateAsync(role);
            }
        }

    }
}