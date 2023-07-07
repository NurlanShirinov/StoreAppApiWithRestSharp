using RestSharp;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.CQRS.Commands.Abstract;

namespace StoreApp.Repository.CQRS.Commands.Concrete
{
    public class ProductCommand : IProductCommand
    {
        private readonly RestClient _client;

        public ProductCommand()
        {
            _client = new RestClient("https://api.escuelajs.co");
        }

        public async Task<GetProductResponseModel> CreateAsync(PostProductRequestModel product)
        {
            try
            {
                var request = new RestRequest("/api/v1/products/").AddJsonBody(product);
                var response = await _client.ExecutePostAsync<GetProductResponseModel>(request);
                return response.Data;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public async Task<bool> DeleteAsync(int id)
        {

            try
            {
                var request = new RestRequest("/api/v1/products/{id}", Method.Delete).AddUrlSegment("id", id.ToString());
                var response = await _client.ExecuteAsync(request);
                if (!response.IsSuccessful) { return false; }
                return true;
            }
            catch (Exception)
            {

                throw;
            }

        }

    

        public async Task<GetProductResponseModel> UpdateAsync(UpdateProductRequestModel product, int id)
        {
            try
            {
                var request = new RestRequest("/api/v1/products/{id}").AddUrlSegment("id", id).AddJsonBody(product);
                var response = await _client.ExecutePutAsync<GetProductResponseModel>(request);
                return response.Data;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
