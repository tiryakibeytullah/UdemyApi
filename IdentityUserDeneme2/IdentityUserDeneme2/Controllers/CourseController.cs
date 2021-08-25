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
    public class CourseController : Controller
    {
        private readonly CourseAPIService _courseAPIService;
        private readonly CategoryAPIService _categoryAPIService;
        private readonly InstructorAPIService _instructorAPIService;
        private readonly OrderAPIService _orderAPIService;
        private readonly UserManager<ApplicationUser> _userManager;
        public CourseController(CourseAPIService courseAPIService, InstructorAPIService instructorAPIService, CategoryAPIService categoryAPIService, OrderAPIService orderAPIService, UserManager<ApplicationUser> userManager)
        {
            this._courseAPIService = courseAPIService;
            this._categoryAPIService = categoryAPIService;
            this._instructorAPIService = instructorAPIService;
            this._orderAPIService = orderAPIService;
            this._userManager = userManager;
            // this._mapper = mapper;
        }
        public void categoryList()
        {
            List<SelectListItem> categoryList = (from x in _categoryAPIService.GetAllAsync().Result
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.Id.ToString()
                                                 }).ToList();

            ViewBag.categoryList = categoryList;
        }
        public void instructorList()
        {
            List<SelectListItem> instructorList = (from x in _instructorAPIService.GetAllAsync().Result
                                                   select new SelectListItem
                                                   {
                                                       Text = x.Name + " " + x.Surname,
                                                       Value = x.Id.ToString()
                                                   }).ToList();

            ViewBag.instructorList = instructorList;
        }
        public async Task<IActionResult> Index()
        {
            var courses = await _courseAPIService.GetAllAsync();

            categoryList();
            instructorList();

            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User));
            if (user != null)
            {
                IList<string> userRole = await _userManager.GetRolesAsync(user);

                ViewBag.roleName = userRole.FirstOrDefault();
            }

            return View(courses);
        }
        public async Task<IActionResult> CourseDetail(int id)
        {
            var course = await _courseAPIService.GetByIdAsync(id);

            return View(course);
        }
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            categoryList();
            instructorList();

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CourseDto courseDto)
        {
            await _courseAPIService.AddAsync(courseDto);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Update(int id)
        {
            var course = await _courseAPIService.GetByIdAsync(id);

            categoryList();
            instructorList();

            return View(course);
        }
        [HttpPost]
        public async Task<IActionResult> Update(CourseDto courseDto)
        {
            await _courseAPIService.Update(courseDto);

            return RedirectToAction("Index");
        }
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(int id)
        {
            await _courseAPIService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
