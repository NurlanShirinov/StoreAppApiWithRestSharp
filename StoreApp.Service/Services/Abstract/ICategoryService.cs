using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Service.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<GetCategoryResponseModel>> GetAllAsync();
        Task<GetCategoryResponseModel> GetByIdAsync(int id);
        Task<GetCategoryResponseModel> CreateAsync(UpdateCategoryRequestModel category);
        Task<GetCategoryResponseModel> UpdateAsync(UpdateCategoryRequestModel category, int id);
        Task<bool> DeleteAsync(int id);
    }
}