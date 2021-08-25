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
    public class StudentAPIService
    {
        private readonly HttpClient _httpClient;
        
        public StudentAPIService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<StudentDto>> GetAllAsync()
        {
            IEnumerable<StudentDto> studentsDtos;

            var response = await _httpClient.GetAsync("students");

            if (response.IsSuccessStatusCode)
            {
                studentsDtos = JsonConvert.DeserializeObject<IEnumerable<StudentDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                studentsDtos = null;
            }

            return studentsDtos;
        }
        public async Task<StudentDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"students/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<StudentDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<StudentDto> GetMail(string mail)
        {
            StudentDto studentDtos;

            var response = await _httpClient.GetAsync($"students/{mail}/mail");

            if (response.IsSuccessStatusCode)
            {
                studentDtos = JsonConvert.DeserializeObject<StudentDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
            
            return studentDtos;
        }
        public async Task<StudentDto> AddAsync(StudentDto studentDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(studentDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("students", stringContent);

            if (response.IsSuccessStatusCode)
            {
                studentDto = JsonConvert.DeserializeObject<StudentDto>(await response.Content.ReadAsStringAsync());

                return studentDto;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> Update(StudentDto studentDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(studentDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("students", stringContent);

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
            var response = await _httpClient.DeleteAsync($"students/{id}");

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
