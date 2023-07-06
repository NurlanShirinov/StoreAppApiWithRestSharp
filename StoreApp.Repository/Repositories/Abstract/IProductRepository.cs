using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Repository.Repositories.Abstract
{
    public interface IProductRepository
    {
        Task<IEnumerable<GetProductResponseModel>> GetAllAsync();
        Task<GetProductResponseModel> GetByIdAsync(int id);
        Task<GetProductResponseModel> CreateAsync(PostProductRequestModel product);
        Task<GetProductResponseModel> UpdateAsync(UpdateProductRequestModel product, int id);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<GetProductResponseModel>> GetProductsByCategoryId(int categoryId);
    }
}
