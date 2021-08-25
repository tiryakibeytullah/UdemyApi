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
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;
        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            this._categoryService = categoryService;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories = await _categoryService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<CategoryDto>>(categories));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var category = await _categoryService.GetByIdAsync(id);

            return Ok(_mapper.Map<CategoryDto>(category));
        }
        [HttpGet("{id}/courses")]
        public async Task<IActionResult> GetWithCoursesById(int id)
        {
            var category = await _categoryService.GetWithCoursesByIdAsync(id);

            return Ok(_mapper.Map<CategoryWithCoursesDto>(category));
        }
        [HttpPost]
        public async Task<IActionResult> Save(CategoryDto categoryDto)
        {
            var newCategory = await _categoryService.AddAsync(_mapper.Map<Category>(categoryDto));

            return Created(string.Empty, _mapper.Map<CategoryDto>(newCategory));
        }
        [HttpPut]
        public IActionResult Update(CategoryDto categoryDto)
        {
            var updateCategory = _categoryService.Update(_mapper.Map<Category>(categoryDto));

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var deleteCategory = _categoryService.GetByIdAsync(id).Result;

            _categoryService.Remove(deleteCategory);

            return NoContent();
        }

    }
}
