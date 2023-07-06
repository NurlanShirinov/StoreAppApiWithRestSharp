using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;

namespace StoreApp.Repository.CQRS.Commands.Abstract
{
    public interface IUserCommand
    {
        Task<User> Post(PostUserRequestModel user);
        Task<User> Put(PutUserRequestModel model, int id);
    }
}