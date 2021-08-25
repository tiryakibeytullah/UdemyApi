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
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public StudentsController(IStudentService studentService, IMapper mapper)
        {
            this._studentService = studentService;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _studentService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<StudentDto>>(students));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _studentService.GetByIdAsync(id);

            return Ok(_mapper.Map<StudentDto>(student));
        }
        [HttpGet("{mail}/mail")]
        public async Task<IActionResult> GetMail(string mail)
        {
            var student = await _studentService.Where(x => x.Mail == mail);

            return Ok(_mapper.Map<IEnumerable<StudentDto>>(student).FirstOrDefault());
        }
        [HttpGet("{id}/courses")]
        public async Task<IActionResult> GetWithCoursesById(int id)
        {
            var getWithCourses = await _studentService.GetWithCoursesByIdAsync(id);

            return Ok(_mapper.Map<StudentWithCoursesDto>(getWithCourses));
        }
        [HttpPost]
        public async Task<IActionResult> Save(StudentDto studentDto)
        {
            var newStudent = await _studentService.AddAsync(_mapper.Map<Student>(studentDto));

            return Created(string.Empty, _mapper.Map<StudentDto>(newStudent));
        }
        [HttpPut]
        public IActionResult Update(StudentDto studentDto)
        {
            var updateStudent = _studentService.Update(_mapper.Map<Student>(studentDto));

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var removeStudent = _studentService.GetByIdAsync(id).Result;
            _studentService.Remove(removeStudent);

            return NoContent();
        }
    }
}
