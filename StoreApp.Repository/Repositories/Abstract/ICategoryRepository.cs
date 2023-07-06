using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repository.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<GetCategoryResponseModel>> GetAllAsync();
        Task<GetCategoryResponseModel> GetByIdAsync(int id);
        Task<GetCategoryResponseModel> CreateAsync(UpdateCategoryRequestModel category);
        Task<GetCategoryResponseModel> UpdateAsync(UpdateCategoryRequestModel category, int id);
        Task<bool> DeleteAsync(int id);
    }
}
