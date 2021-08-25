using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer_Project.API.DTOs;
using UdemyNLayer_Project.Core;
using UdemyNLayer_Project.Core.Services;
using UdemyNLayer_Project.Service.Services;

namespace UdemyNLayer_Project.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructorsController : ControllerBase
    {
        private readonly IInstructorService _instructorService;
        private readonly IMapper _mapper;
        public InstructorsController(IInstructorService instructorService, IMapper mapper)
        {
            this._instructorService = instructorService;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var instructors = await _instructorService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<InstructorDto>>(instructors));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var instructor = await _instructorService.GetByIdAsync(id);

            return Ok(_mapper.Map<InstructorDto>(instructor));
        }
        [HttpGet("{id}/courses")]
        public async Task<IActionResult> GetWithCourseById(int id)
        {
            var instructor = await _instructorService.GetWithCoursesByIdAsync(id);

            return Ok(_mapper.Map<InstructorWithCoursesDto>(instructor));
        }
        [HttpPost]
        public async Task<IActionResult> Save(InstructorDto instructorDto)
        {
            var newInstructor = await _instructorService.AddAsync(_mapper.Map<Instructor>(instructorDto));

            return Created(string.Empty, _mapper.Map<InstructorDto>(newInstructor));
        }
        [HttpPut]
        public IActionResult Update(InstructorDto instructorDto)
        {
            var updateInstructor = _instructorService.Update(_mapper.Map<Instructor>(instructorDto));

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var removeInstructor = _instructorService.GetByIdAsync(id).Result;
            _instructorService.Remove(removeInstructor);

            return NoContent();
        }
    }
}
