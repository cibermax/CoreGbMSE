using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebUI.Models;

namespace WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = "Администратор")]
    public class UsersController : Controller
    {
 

        public UserManager<ApplicationUser> _UserManager { get; }
        public RoleManager<IdentityRole> _RoleManager { get; }

        public UsersController(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _UserManager = userManager;
            _RoleManager = roleManager;
        }

        // GET: Users
        public ActionResult Index()
        {
           return View(_UserManager.Users.ToList());
        }

        // GET: Users/Details/5
        public async Task<ActionResult> Details(string id)
        {
            var user = await _UserManager.FindByIdAsync(id);
            ViewBag.Roles = _RoleManager.Roles;
            //ViewBag.CurrentRoles = await _UserManager.GetRolesAsync(user);
            var strRolesList = await _UserManager.GetRolesAsync(user);
            var idRoles = new List<IdentityRole>();
            //idRoles.Clear();
            foreach (var item in strRolesList)
            {
                idRoles.Add(_RoleManager.Roles.Single(x => x.Name == item));
            }
            
            ViewBag.CurrentRoles = idRoles;
            return View(user);
        }

        // GET: Users/Delete/5
        public async Task<ActionResult> DeleteAsync(string id)
        {
            var user = await _UserManager.FindByIdAsync(id);
            return View(user);
        }


        // POST: Users/Delete/5
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteAsync(string id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                var user = await _UserManager.FindByIdAsync(id);
                var x = await _UserManager.DeleteAsync(user);


                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        public async Task<ActionResult> UserRoles(string id)
        {
            var user = await _UserManager.FindByIdAsync(id);
            ViewBag.Roles = _RoleManager.Roles;
            //ViewBag.CurrentRoles = await _UserManager.GetRolesAsync(user);
            var strRolesList = await _UserManager.GetRolesAsync(user);
            var idRoles = new List<IdentityRole>();
            foreach (var item in strRolesList)
            {
                idRoles.Add(_RoleManager.Roles.Single(x => x.Name == item));
            }

            ViewBag.CurrentRoles = idRoles;
            return View(user);
        }

        [HttpPost]
        public async Task<ActionResult> UserRoles(string[] roles, ApplicationUser user)
        {
            var usr = await _UserManager.FindByIdAsync(user.Id);

            var currroles = await _UserManager.GetRolesAsync(usr);

            await _UserManager.UpdateSecurityStampAsync(usr);



            await _UserManager.RemoveFromRolesAsync(usr, currroles.ToArray());

            await _UserManager.AddToRolesAsync(usr, roles);


            return RedirectToAction("Index");
        }


    }

}