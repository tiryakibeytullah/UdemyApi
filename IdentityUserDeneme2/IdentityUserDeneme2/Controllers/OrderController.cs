using IdentityUserDeneme2.APIService;
using IdentityUserDeneme2.Areas.Identity.Data;
using IdentityUserDeneme2.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.Controllers
{
    public class OrderController : Controller
    {
        private readonly OrderAPIService _orderAPIService;
        private readonly StudentAPIService _studentAPIService;
        private readonly CourseAPIService _courseAPIService;
        private readonly UserManager<ApplicationUser> _userManager;
        public OrderController(OrderAPIService orderAPIService, StudentAPIService studentAPIService, CourseAPIService courseAPIService, UserManager<ApplicationUser> userManager)
        {
            this._orderAPIService = orderAPIService;
            this._studentAPIService = studentAPIService;
            this._courseAPIService = courseAPIService;
            this._userManager = userManager;
        }
        public void studentList()
        {
            List<SelectListItem> studentList = (from x in _studentAPIService.GetAllAsync().Result
                                                select new SelectListItem
                                                {
                                                    Text = x.Name + " " + x.Surname,
                                                    Value = x.Id.ToString()
                                                }).ToList();

            ViewData["studentList"] = studentList;
        }
        public void courseList()
        {
            List<SelectListItem> courseList = (from x in _courseAPIService.GetAllAsync().Result
                                               select new SelectListItem
                                               {
                                                   Text = x.Name,
                                                   Value = x.Id.ToString()
                                               }).ToList();

            ViewData["courseList"] = courseList;
        }
        [Authorize(Roles = "Admin, Student")]
        public async Task<IActionResult> Index()
        {
            var orders = await _orderAPIService.GetAllAsync();

            var user = await _userManager.FindByIdAsync(_userManager.GetUserId(HttpContext.User));
            if (user != null)
            {
                IList<string> userRole = await _userManager.GetRolesAsync(user);

                ViewBag.roleName = userRole.FirstOrDefault();
            }

            var userOfEmail = await _studentAPIService.GetMail(User.Identity.Name);

            ViewBag.userId = userOfEmail.Id;

            studentList();
            courseList();

            return View(orders);
        }
        [Authorize(Roles = "Admin, Student")]
        public async Task<IActionResult> GetWithCourse(int id)
        {
            // Düzenlenicek.
            var orderWithCourse = await _orderAPIService.GetWithCourseAsync(id);

            var orderWithStudent = await _orderAPIService.GetWithStudentAsync(id);

            ViewBag.orderWithStudent = orderWithStudent;

            return View(orderWithCourse);
        }
        [Authorize(Roles = "Student")]
        public async Task<IActionResult> Create(int id)
        {
            var courses = await _courseAPIService.GetByIdAsync(id);

            return View(courses);
        }
        [Authorize(Roles = "Student")]
        [HttpPost]
        public async Task<IActionResult> Create(CourseDto courseDto)
        {
            var user = await _studentAPIService.GetMail(User.Identity.Name);

            OrderDto newOrder = new OrderDto
            {
                CourseId = courseDto.Id,
                StudentId = user.Id
            };

            await _orderAPIService.AddAsync(newOrder);

            return RedirectToAction("Index");
        }
    }
}
