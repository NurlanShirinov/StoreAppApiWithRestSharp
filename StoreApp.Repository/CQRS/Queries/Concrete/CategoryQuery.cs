using RestSharp;
using StoreApp.Core.Models;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.CQRS.Queries.Abstract;
using System.Text.Json;

namespace StoreApp.Repository.CQRS.Queries.Concrete
{
    public class CategoryQuery : ICategoryQuery
    {
        private readonly RestClient _client;

        public CategoryQuery()
        {
            _client = new RestClient("https://api.escuelajs.co");
        }

        public async Task<IEnumerable<GetCategoryResponseModel>> GetAllAsync()
        {
            var request = new RestRequest("api/v1/categories");
            var response = await _client.ExecuteGetAsync(request);
            var categoryList = JsonSerializer.Deserialize<IEnumerable<GetCategoryResponseModel>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
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
