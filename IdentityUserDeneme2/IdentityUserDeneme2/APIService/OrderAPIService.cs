using IdentityUserDeneme2.DTOs;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace IdentityUserDeneme2.APIService
{
    public class OrderAPIService
    {
        private readonly HttpClient _httpClient;
        public OrderAPIService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<OrderDto>> GetAllAsync()
        {
            IEnumerable<OrderDto> orderDtos;

            var response = await _httpClient.GetAsync("orders");

            if (response.IsSuccessStatusCode)
            {
                orderDtos = JsonConvert.DeserializeObject<IEnumerable<OrderDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                orderDtos = null;
            }

            return orderDtos;
        }
        public async Task<OrderDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"orders/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<OrderDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<OrderWithCourseDto> GetWithCourseAsync(int id)
        {
            var response = await _httpClient.GetAsync($"orders/{id}/courses");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<OrderWithCourseDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<OrderWithStudentDto> GetWithStudentAsync(int id)
        {
            var response = await _httpClient.GetAsync($"orders/{id}/students");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<OrderWithStudentDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<OrderDto> AddAsync(OrderDto orderDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(orderDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("orders", stringContent);

            if (response.IsSuccessStatusCode)
            {
                orderDto = JsonConvert.DeserializeObject<OrderDto>(await response.Content.ReadAsStringAsync());

                return orderDto;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> Update(OrderDto orderDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(orderDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("orders", stringContent);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public async Task<bool> Remove(int id)
        {
            var response = await _httpClient.DeleteAsync($"orders/{id}");

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
