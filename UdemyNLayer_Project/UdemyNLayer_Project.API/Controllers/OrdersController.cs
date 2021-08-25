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
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public OrdersController(IOrderService orderService, IStudentService studentService, IMapper mapper)
        {
            this._orderService = orderService;
            this._studentService = studentService;
            this._mapper = mapper;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var orders = await _orderService.GetAllAsync();

            return Ok(_mapper.Map<IEnumerable<OrderDto>>(orders));
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var order = await _orderService.GetByIdAsync(id);

            return Ok(_mapper.Map<OrderDto>(order));
        }
        [HttpGet("{id}/courses")]
        public async Task<IActionResult> GetWithCoursesById(int id)
        {
            var orderWithCourse = await _orderService.GetWithCourseByIdAsync(id);

            return Ok(_mapper.Map<OrderWithCourseDto>(orderWithCourse));
        }
        [HttpGet("{id}/students")]
        public async Task<IActionResult> GetWithStudentsById(int id)
        {
            var orderWithStudent = await _orderService.GetWithStudentByIdAsync(id);

            return Ok(_mapper.Map<OrderWithStudentDto>(orderWithStudent));
        }
        [HttpPost]
        public async Task<IActionResult> Save(OrderDto orderDto)
        {
            var newOrder = await _orderService.AddAsync(_mapper.Map<Order>(orderDto));

            return Created(string.Empty, newOrder);
        }
        [HttpPut]
        public IActionResult Update(OrderDto orderDto)
        {
            var updateOrder = _orderService.Update(_mapper.Map<Order>(orderDto));

            return NoContent();
        }
        [HttpDelete("{id}")]
        public IActionResult Remove(int id)
        {
            var removeOrder = _orderService.GetByIdAsync(id).Result;
            _orderService.Remove(removeOrder);

            return NoContent();
        }
    }
}
