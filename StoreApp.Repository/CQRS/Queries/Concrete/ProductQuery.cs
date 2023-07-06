using RestSharp;
using StoreApp.Core.Models;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.CQRS.Queries.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace StoreApp.Repository.CQRS.Queries.Concrete
{
    public class ProductQuery : IProductQuery
    {
        private readonly RestClient _client;

        public ProductQuery()
        {
            _client = new RestClient("https://api.escuelajs.co");
        }

        public async Task<IEnumerable<GetProductResponseModel>> GetAllAsync()
        {
            try
            {
                var request = new RestRequest("/api/v1/products");
                var response = await _client.ExecuteGetAsync(request);
                var productList = JsonSerializer.Deserialize<IEnumerable<GetProductResponseModel>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return productList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<GetProductResponseModel> GetByIdAsync(int id)
        {
            try
            {
                var request = new RestRequest("/api/v1/products/{id}");
                request.AddUrlSegment("id", id.ToString());
                var response = await _client.ExecuteGetAsync(request);
                var product = JsonSerializer.Deserialize<GetProductResponseModel>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return product;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<IEnumerable<GetProductResponseModel>> GetProductsByCategoryId(int categoryId)
        {
            try
            {
                var request = new RestRequest("/api/v1/products");
                var response = await _client.ExecuteGetAsync(request);
                var productList = JsonSerializer.Deserialize<IEnumerable<GetProductResponseModel>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var filteredList = productList.Where(x => x.Category.Id == categoryId);
                return filteredList;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}