using IdentityUserDeneme2.APIService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.Controllers
{
    public class StudentController : Controller
    {
        private readonly StudentAPIService _studentAPIService;
        public StudentController(StudentAPIService studentAPIService)
        {
            this._studentAPIService = studentAPIService;
        }
        [Authorize(Roles = "Admin, Student")]
        public async Task<IActionResult> Index()
        {
            var students = await _studentAPIService.GetAllAsync();

            return View(students);
        }
    }
}
