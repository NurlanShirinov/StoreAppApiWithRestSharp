using StoreApp.Core.Models;
using StoreApp.Core.ResponseModels;

namespace StoreApp.Repository.CQRS.Queries.Abstract
{
    public interface ICategoryQuery
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<GetCategoryResponseModel> GetByIdAsync(int id);


    }
}
