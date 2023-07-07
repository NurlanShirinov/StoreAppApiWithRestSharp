using StoreApp.Core.Models;

namespace StoreApp.Repository.CQRS.Queries.Abstract
{
    public interface IUserQuery
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<bool> CheckUserByEmailAsync(string email);
    }
}
