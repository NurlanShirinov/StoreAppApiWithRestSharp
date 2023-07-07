using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Repository.Repositories.Abstract;
using StoreApp.Service.Services.Abstract;

namespace StoreApp.Service.Services.Concrete
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<bool> CheckUserByEmailAsync(string email)
        {
            var result = await _userRepository.CheckUserByEmailAsync(email);
            return result;
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            var result = await _userRepository.GetAllAsync();
            return result;
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var result = await _userRepository.GetByIdAsync(id);
            return result;
        }

        public async Task<User> Post(PostUserRequestModel user)
        {
            var result = await _userRepository.Post(user);
            return result;
        }

        public async Task<User> Put(PutUserRequestModel model, int id)
        {
            var result = await _userRepository.Put(model, id);
            return result;
        }
    }
}
