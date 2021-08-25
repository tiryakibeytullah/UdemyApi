using IdentityUserDeneme2.Areas.Identity.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.Controllers
{
    public class RoleController : Controller
    {
        RoleManager<IdentityRole> _roleManager;
        public RoleController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this._roleManager = roleManager;
        }
        public IActionResult Index()
        {
            var roles = _roleManager.Roles.ToList();

            return View(roles);
        }
        public IActionResult Create()
        {
            return View(new IdentityRole());
        }
        [HttpPost]
        public async Task<IActionResult> Create(IdentityRole identityRole)
        {
            await _roleManager.CreateAsync(identityRole);
            return RedirectToAction("Index", "Role");
        }
    }
}
