using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Repository.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<GetCategoryResponseModel> GetByIdAsync(int id);
        Task<GetCategoryResponseModel> CreateAsync(UpdateCategoryRequestModel category);
        Task<GetCategoryResponseModel> UpdateAsync(UpdateCategoryRequestModel category, int id);
        Task<bool> DeleteAsync(int id);
    }
}
