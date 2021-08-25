using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer_Project.Web.APIService;
using UdemyNLayer_Project.Web.DTOs;

namespace UdemyNLayer_Project.Web.Controllers
{
    public class CoursesController : Controller
    {
        private readonly CourseAPIService _courseAPIService;
        private readonly CategoryAPIService _categoryAPIService;
        private readonly InstructorAPIService _instructorAPIService;
        private readonly IMapper _mapper;
        public CoursesController(CourseAPIService courseAPIService, InstructorAPIService instructorAPIService, CategoryAPIService categoryAPIService, IMapper mapper)
        {
            this._courseAPIService = courseAPIService;
            this._categoryAPIService = categoryAPIService;
            this._instructorAPIService = instructorAPIService;
            this._mapper = mapper;
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

            return View(courses);
        }
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
        public async Task<IActionResult> Delete(int id)
        {
            await _courseAPIService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
