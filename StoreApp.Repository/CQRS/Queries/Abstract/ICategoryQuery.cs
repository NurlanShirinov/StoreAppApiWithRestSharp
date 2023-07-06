using StoreApp.Core.Models;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Repository.CQRS.Queries.Abstract
{
    public interface ICategoryQuery
    {
        Task<IEnumerable<GetCategoryResponseModel>> GetAllAsync();
        Task<GetCategoryResponseModel> GetByIdAsync(int id);
    }
}
