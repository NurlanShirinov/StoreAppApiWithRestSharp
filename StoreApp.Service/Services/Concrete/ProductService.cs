using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.Repositories.Abstract;
using StoreApp.Service.Services.Abstract;

namespace StoreApp.Service.Services.Concrete
{
    public class ProductService : IProductService
    {

        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<GetProductResponseModel> CreateAsync(PostProductRequestModel product)
        {
            var result = await _productRepository.CreateAsync(product);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _productRepository.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<GetProductResponseModel>> GetAllAsync()
        {
            var result = await _productRepository.GetAllAsync();
            return result;
        }

        public async Task<GetProductResponseModel> GetByIdAsync(int id)
        {
            var result = await _productRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<IEnumerable<GetProductResponseModel>> GetProductsByCategoryId(int categoryId)
        {
            var result = await _productRepository.GetProductsByCategoryId(categoryId);
            return result;
        }

        public async Task<GetProductResponseModel> UpdateAsync(UpdateProductRequestModel product, int id)
        {
            var result = await _productRepository.UpdateAsync(product, id);
            return result;
        }
    }
}
