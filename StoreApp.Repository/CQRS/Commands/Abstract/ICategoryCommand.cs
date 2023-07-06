using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;

namespace StoreApp.Repository.CQRS.Commands.Abstract
{
    public interface ICategoryCommand
    {
        Task<Category> CreateAsync(UpdateCategoryRequestModel category);
        Task<Category> UpdateAsync (UpdateCategoryRequestModel category, int id);
        Task<bool> DeleteAsync(int id);
    }
}