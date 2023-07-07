using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Service.Services.Abstract
{
    public interface IProductService
    {
        Task<IEnumerable<GetProductResponseModel>> GetAllAsync();
        Task<GetProductResponseModel> GetByIdAsync(int id);
        Task<GetProductResponseModel> CreateAsync(PostProductRequestModel product);
        Task<GetProductResponseModel> UpdateAsync(UpdateProductRequestModel product, int id);
        Task<bool> DeleteAsync(int id);
        Task<IEnumerable<GetProductResponseModel>> GetProductsByCategoryId(int categoryId);
    }
}
