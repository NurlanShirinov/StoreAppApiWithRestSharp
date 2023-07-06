using StoreApp.Core.Models;
using StoreApp.Core.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreApp.Repository.CQRS.Queries.Abstract
{
    public interface IProductQuery
    {
        Task<IEnumerable<GetProductResponseModel>> GetAllAsync();
        Task<GetProductResponseModel> GetByIdAsync(int id);
        Task<IEnumerable<GetProductResponseModel>> GetProductsByCategoryId(int categoryId);
    }
}
