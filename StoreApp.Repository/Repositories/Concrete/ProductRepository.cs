using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;
using StoreApp.Repository.CQRS.Commands.Abstract;
using StoreApp.Repository.CQRS.Queries.Abstract;
using StoreApp.Repository.Repositories.Abstract;

namespace StoreApp.Repository.Repositories.Concrete
{
    public class ProductRepository : IProductRepository
    {

        private readonly IProductQuery _productQuery;
        private readonly IProductCommand _productCommand;

        public ProductRepository(IProductQuery productQuery, IProductCommand productCommand)
        {
            _productQuery = productQuery;
            _productCommand = productCommand;
        }

        public async Task<GetProductResponseModel> CreateAsync(PostProductRequestModel product)
        {
            var result = await _productCommand.CreateAsync(product);
            return result;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var result = await _productCommand.DeleteAsync(id);
            return result;
        }

        public async Task<IEnumerable<GetProductResponseModel>> GetAllAsync()
        {
            var result = await _productQuery.GetAllAsync();
            return result;
        }

        public async Task<GetProductResponseModel> GetByIdAsync(int id)
        {
            var result = await _productQuery.GetByIdAsync(id);
            return result;
        }

        public async Task<IEnumerable<GetProductResponseModel>> GetProductsByCategoryId(int categoryId)
        {
            var result = await _productQuery.GetProductsByCategoryId(categoryId);
            return result;
        }

        public async Task<GetProductResponseModel> UpdateAsync(UpdateProductRequestModel product, int id)
        {
            var result = await _productCommand.UpdateAsync(product, id);
            return result;
        }
    }
}
