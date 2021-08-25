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
    public class InstructorAPIService
    {
        private readonly HttpClient _httpClient;
        public InstructorAPIService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<InstructorDto>> GetAllAsync()
        {
            IEnumerable<InstructorDto> instructorDtos;

            var response = await _httpClient.GetAsync("instructors");

            if (response.IsSuccessStatusCode)
            {
                instructorDtos = JsonConvert.DeserializeObject<IEnumerable<InstructorDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                instructorDtos = null;
            }

            return instructorDtos;
        }
        public async Task<InstructorDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"instructors/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<InstructorDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<InstructorWithCoursesDto> GetWithCourseById(int id)
        {
            var response = await _httpClient.GetAsync($"instructors/{id}/courses");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<InstructorWithCoursesDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<InstructorDto> AddAsync(InstructorDto instructorDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(instructorDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("instructors", stringContent);

            if (response.IsSuccessStatusCode)
            {
                instructorDto = JsonConvert.DeserializeObject<InstructorDto>(await response.Content.ReadAsStringAsync());

                return instructorDto;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> Update(InstructorDto instructorDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(instructorDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("instructors", stringContent);

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
            var response = await _httpClient.DeleteAsync($"instructors/{id}");

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
