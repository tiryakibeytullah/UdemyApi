using IdentityUserDeneme2.APIService;
using IdentityUserDeneme2.Areas.Identity.Data;
using IdentityUserDeneme2.Data;
using IdentityUserDeneme2.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryAPIService _categoryAPIService;
        private readonly UserManager<ApplicationUser> _userManager;
        // private readonly IMapper _mapper;
        public CategoryController(CategoryAPIService categoryAPIService, UserManager<ApplicationUser> userManager)
        {
            this._categoryAPIService = categoryAPIService;
            this._userManager = userManager;
            //this._mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryAPIService.GetAllAsync();

            // ViewBag.userId = _userManager.GetUserId(HttpContext.User);
            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User));
            if (user != null)
            {
                IList<string> userRole = await _userManager.GetRolesAsync(user);

                ViewBag.roleName = userRole.FirstOrDefault();
            }

            return View(categories);
        }
        public async Task<IActionResult> IndexWithCourse(int id)
        {
            var categoryWithCourse = await _categoryAPIService.GetWithCourseById(id);

            return View(categoryWithCourse);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            await _categoryAPIService.AddAsync(categoryDto);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id)
        {
            var category = await _categoryAPIService.GetByIdAsync(id);

            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CategoryDto categoryDto)
        {
            await _categoryAPIService.Update(categoryDto);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryAPIService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
