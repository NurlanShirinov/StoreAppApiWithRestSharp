using Microsoft.EntityFrameworkCore;
using RestSharp;
using StoreApp.Core.DAL;
using StoreApp.Core.Models;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.CQRS.Queries.Abstract;
using System.Text.Json;

namespace StoreApp.Repository.CQRS.Queries.Concrete
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly RestClient _client;
        private readonly AppDbContext _context;

        public CategoryQuery(AppDbContext context)
        {
            _client = new RestClient("https://api.escuelajs.co");
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            var request = new RestRequest("api/v1/categories");
            var response = await _client.ExecuteGetAsync(request);
            var categoryList = JsonSerializer.Deserialize<IEnumerable<Category>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });

            return categoryList;
        }


        public async Task<GetCategoryResponseModel> GetByIdAsync(int id)
        {
            var request = new RestRequest("/api/v1/categories/{id}");
            request.AddUrlSegment("id", id.ToString());
            var response = await _client.ExecuteGetAsync(request);
            var category = JsonSerializer.Deserialize<GetCategoryResponseModel>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            return category;
        }

    }
}
