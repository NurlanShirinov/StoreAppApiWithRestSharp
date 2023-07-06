using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Repository.CQRS.Commands.Abstract
{
    public interface ICategoryCommand
    {
        Task<GetCategoryResponseModel> CreateAsync(UpdateCategoryRequestModel category);
        Task<GetCategoryResponseModel> UpdateAsync (UpdateCategoryRequestModel category, int id);
        Task<bool> DeleteAsync(int id);
    }
}