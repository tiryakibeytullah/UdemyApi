using IdentityUserDeneme2.APIService;
using IdentityUserDeneme2.Areas.Identity.Data;
using IdentityUserDeneme2.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.Controllers
{
    public class InstructorController : Controller
    {
        private readonly InstructorAPIService _instructorAPIService;
        private readonly UserManager<ApplicationUser> _userManager;
        public InstructorController(InstructorAPIService instructorAPIService, UserManager<ApplicationUser> userManager)
        {
            this._instructorAPIService = instructorAPIService;
            this._userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var instructors = await _instructorAPIService.GetAllAsync();

            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User));
            if (user != null)
            {
                IList<string> userRole = await _userManager.GetRolesAsync(user);

                ViewBag.roleName = userRole.FirstOrDefault();
            }

            return View(instructors);
        }
        public async Task<IActionResult> IndexWithCourses(int id)
        {
            var instructorsWithCourses = await _instructorAPIService.GetWithCourseById(id);

            return View(instructorsWithCourses);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(InstructorDto instructorDto)
        {
            await _instructorAPIService.AddAsync(instructorDto);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id)
        {
            var instructor = await _instructorAPIService.GetByIdAsync(id);

            return View(instructor);
        }
        [HttpPost]
        public async Task<IActionResult> Update(InstructorDto instructorDto)
        {
            await _instructorAPIService.Update(instructorDto);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await _instructorAPIService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
