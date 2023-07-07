using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Repository.CQRS.Commands.Abstract;
using StoreApp.Repository.CQRS.Queries.Abstract;
using StoreApp.Repository.Repositories.Abstract;

namespace StoreApp.Repository.Repositories.Concrete
{
    public class UserRepository : IUserRepository
    {
        private readonly IUserQuery _userQuery;
        private readonly IUserCommand _userCommand;

        public UserRepository(IUserQuery userQuery, IUserCommand userCommand)
        {
            _userQuery = userQuery;
            _userCommand = userCommand;
        }

        public async Task<bool> CheckUserByEmailAsync(string email)
        {
            var result = await _userQuery.CheckUserByEmailAsync(email);
            return result;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var result = await _userQuery.GetAllAsync();
            return result;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var result = await _userQuery.GetByIdAsync(id);
            return result;
        }

        public async Task<User> Post(PostUserRequestModel user)
        {
            var result = await _userCommand.Post(user);
            return result;
        }

        public async Task<User> Put(PutUserRequestModel model , int id)
        {
            var result = await _userCommand.Put(model, id);
            return result;
        }
    }
}