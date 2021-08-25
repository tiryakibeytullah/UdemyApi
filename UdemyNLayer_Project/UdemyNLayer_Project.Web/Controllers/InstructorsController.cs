using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer_Project.Web.APIService;
using UdemyNLayer_Project.Web.DTOs;

namespace UdemyNLayer_Project.Web.Controllers
{
    public class InstructorsController : Controller
    {
        private readonly InstructorAPIService _instructorAPIService;
        public InstructorsController(InstructorAPIService instructorAPIService)
        {
            this._instructorAPIService = instructorAPIService;
        }
        public async Task<IActionResult> Index()
        {
            var instructors = await _instructorAPIService.GetAllAsync();

            return View(instructors);
        }
        public async Task<IActionResult> IndexWithCourses(int id)
        {
            var instructorsWithCourses = await _instructorAPIService.GetWithCourseById(id);

            return View(instructorsWithCourses);
        }
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
        public async Task<IActionResult> Delete(int id)
        {
            await _instructorAPIService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
