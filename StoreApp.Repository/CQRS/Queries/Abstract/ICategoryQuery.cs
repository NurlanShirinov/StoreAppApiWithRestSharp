using StoreApp.Core.Models;

namespace StoreApp.Repository.CQRS.Queries.Abstract
{
    public interface ICategoryQuery
    {
        Task<IEnumerable<Category>> GetAllAsync();
        Task<Category> GetByIdAsync(int id);
    }
}
