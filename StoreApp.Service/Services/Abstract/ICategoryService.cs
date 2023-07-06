using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Service.Services.Abstract
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
        Task<Category> CreateAsync(UpdateCategoryRequestModel category);
        Task<Category> UpdateAsync(UpdateCategoryRequestModel category, int id);
        Task<bool> DeleteAsync(int id);
    }
}