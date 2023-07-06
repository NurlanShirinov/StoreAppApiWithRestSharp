using RestSharp;
using StoreApp.Core.Models;
using StoreApp.Repository.CQRS.Queries.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StoreApp.Repository.CQRS.Queries.Concrete
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly RestClient _client;

        public CategoryQuery()
        {
            _client = new RestClient("https://api.escuelajs.co");
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var request = new RestRequest("api/v1/categories");
            var response = await _client.ExecuteGetAsync(request);
            var categoryList = JsonSerializer.Deserialize<IEnumerable<Category>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return categoryList;
        }

        public async Task<Category> GetByIdAsync(int id)
        {
            var request = new RestRequest("/api/v1/categories/{id}");
            request.AddUrlSegment("id", id.ToString());
            var response = await _client.ExecuteGetAsync(request);
            var category = JsonSerializer.Deserialize<Category>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return category;
        }
    }
}
