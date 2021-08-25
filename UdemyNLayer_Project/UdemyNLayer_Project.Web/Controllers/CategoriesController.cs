using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UdemyNLayer_Project.Web.APIService;
using UdemyNLayer_Project.Web.DTOs;

namespace UdemyNLayer_Project.Web.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly CategoryAPIService _categoryAPIService;
        private readonly IMapper _mapper;
        public CategoriesController(IMapper mapper, CategoryAPIService categoryAPIService)
        {
            this._categoryAPIService = categoryAPIService;
            this._mapper = mapper;
        }
        public async Task<IActionResult> Index()
        {
            var categories = await _categoryAPIService.GetAllAsync();

            return View(categories);
        }
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
        public async Task<IActionResult> Delete(int id)
        {
            await _categoryAPIService.Remove(id);

            return RedirectToAction("Index");
        }
    }
}
