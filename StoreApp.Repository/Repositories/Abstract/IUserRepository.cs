using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;

namespace StoreApp.Repository.Repositories.Abstract
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllAsync();
        Task<User> GetByIdAsync(int id);
        Task<User> Post(PostUserRequestModel user);
        Task<User> Put(PutUserRequestModel model, int id);
        Task<bool> CheckUserByEmailAsync(string email);
    }
}
