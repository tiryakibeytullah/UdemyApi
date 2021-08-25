using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer_Project.API.DTOs;
using UdemyNLayer_Project.Core.Models;
using UdemyNLayer_Project.Core.Services;

namespace UdemyNLayer_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoursesController : ControllerBase
    {
        private readonly ICourseService _courseService;
        private readonly IMapper _mapper;
        public CoursesController(ICourseService courseService, IMapper mapper)
        {
            this._courseService = courseService;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var courses = await _courseService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<CourseDto>>(courses));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var course = await _courseService.GetByIdAsync(id);

            return Ok(_mapper.Map<CourseDto>(course));
        }
        [HttpGet("{id}/instructors")]
        public async Task<IActionResult> GetWithInstructorsById(int id)
        {
            var courseWithInstructor = await _courseService.GetWithInstructorsByIdAsync(id);

            return Ok(_mapper.Map<CourseWithInstructorDto>(courseWithInstructor));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CourseDto courseDto)
        {
            var newCourse = await _courseService.AddAsync(_mapper.Map<Course>(courseDto));

            return Created(string.Empty, newCourse);
        }
        [HttpPut]
        public IActionResult Update(CourseDto courseDto)
        {
            var updateCourse = _courseService.Update(_mapper.Map<Course>(courseDto));

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var removeCourse = _courseService.GetByIdAsync(id).Result;
            _courseService.Remove(removeCourse);

            return NoContent();
        }
    }
}
