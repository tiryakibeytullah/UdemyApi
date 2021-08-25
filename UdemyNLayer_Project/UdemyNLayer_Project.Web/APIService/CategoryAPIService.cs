using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using UdemyNLayer_Project.Web.DTOs;

namespace UdemyNLayer_Project.Web.APIService
{
    public class CategoryAPIService
    {
        private readonly HttpClient _httpClient;

        public CategoryAPIService(HttpClient httpClient)
        {
            this._httpClient = httpClient;
        }
        public async Task<IEnumerable<CategoryDto>> GetAllAsync()
        {
            IEnumerable<CategoryDto> categoryDtos;

            var response = await _httpClient.GetAsync("categories");

            if (response.IsSuccessStatusCode)
            {
                categoryDtos = JsonConvert.DeserializeObject<IEnumerable<CategoryDto>>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                categoryDtos = null;
            }

            return categoryDtos;
        }
        public async Task<CategoryDto> GetByIdAsync(int id)
        {
            var response = await _httpClient.GetAsync($"categories/{id}");

            if (response.IsSuccessStatusCode)
            {
                return JsonConvert.DeserializeObject<CategoryDto>(await response.Content.ReadAsStringAsync());
            }
            else
            {
                return null;
            }
        }
        public async Task<CategoryDto> AddAsync(CategoryDto categoryDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(categoryDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("categories", stringContent);

            if (response.IsSuccessStatusCode)
            {
                categoryDto = JsonConvert.DeserializeObject<CategoryDto>(await response.Content.ReadAsStringAsync());

                return categoryDto;
            }
            else
            {
                return null;
            }
        }
        public async Task<bool> Update(CategoryDto categoryDto)
        {
            var stringContent = new StringContent(JsonConvert.SerializeObject(categoryDto), Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync("categories", stringContent);

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
            var response = await _httpClient.DeleteAsync($"categories/{id}");

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
