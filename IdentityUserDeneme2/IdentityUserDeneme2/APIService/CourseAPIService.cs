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
    public class CourseAPIService
    {
        private readonly HttpClient _httpClient;
        public CourseAPIService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<CourseDto>> GetAllAsync()
        {
            IEnumerable<CourseDto> courseDtos;

            var response = await _httpClient.GetAsync("courses");

            if (response.IsSuccessStatusCode)
            {
                courseDtos = JsonConvert.DeserializeObject<IEnumerable<CourseDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                courseDtos = null;
            }

            return courseDtos;
        }
        public async Task<CourseDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"courses/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CourseDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<CourseDto> AddAsync(CourseDto courseDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(courseDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("courses", stringContent);

            if (response.IsSuccessStatusCode)
            {
                courseDto = JsonConvert.DeserializeObject<CourseDto>(await response.Content.ReadAsStringAsync());

                return courseDto;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> Update(CourseDto courseDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(courseDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("courses", stringContent);

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
            var response = await _httpClient.DeleteAsync($"courses/{id}");

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
