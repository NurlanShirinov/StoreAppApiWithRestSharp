using RestSharp;
using StoreApp.Core.Models;
using StoreApp.Core.RequestModels;
using StoreApp.Repository.CQRS.Commands.Abstract;

namespace StoreApp.Repository.CQRS.Commands.Concrete
{
    public class UserCommand : IUserCommand
    {
        private readonly RestClient _client;

        public UserCommand()
        {
            _client = new RestClient("https://api.escuelajs.co");
        }

        public async Task<User> Post(PostUserRequestModel user)
        {
            try
            {
                var request = new RestRequest("/api/v1/users/").AddJsonBody(user);
                var response = await _client.ExecutePostAsync<User>(request);
                return response.Data;
            }
            catch (Exception ex)
            {
                throw new Exception($"Error occurred: {ex.Message}");
            }
        }

        public async Task<User> Put(PutUserRequestModel model, int id)
        {
            try
            {
                var request = new RestRequest("/api/v1/users/{id}")
                    .AddUrlSegment("id", id)
                    .AddJsonBody(model);
                var response = await _client.ExecutePutAsync<User>(request);

                return response.Data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
