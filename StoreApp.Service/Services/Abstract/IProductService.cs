using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Core.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
