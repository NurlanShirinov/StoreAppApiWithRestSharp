using RestSharp;
using StoreApp.Core.Models;
using StoreApp.Repository.CQRS.Queries.Abstract;
using System.Text.Json;

namespace StoreApp.Repository.CQRS.Queries.Concrete
{
    public class UserQuery : IUserQuery
    {
        private readonly RestClient _client;

        public UserQuery()
        {
            _client = new RestClient("https://api.escuelajs.co");
        }

        public async Task<bool> CheckUserByEmailAsync(string email)
        {
            try
            {
                var request = new RestRequest("/api/v1/users");
                var response = await _client.ExecuteGetAsync(request);
                var userList = JsonSerializer.Deserialize<IEnumerable<User>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                var result = userList.FirstOrDefault(x => x.Email == email);
                if (result != null) { return true; };
                return false;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            try
            {
                var request = new RestRequest("/api/v1/users");
                var response = await _client.ExecuteGetAsync(request);
                var userList = JsonSerializer.Deserialize<IEnumerable<User>>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return userList.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public async Task<User> GetByIdAsync(int id)
        {
            try
            {
                var request = new RestRequest("/api/v1/users/{id}");
                request.AddUrlSegment("id", id.ToString());
                var response = await _client.ExecuteGetAsync(request);
                var currentUser = JsonSerializer.Deserialize<User>(response.Content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
                return currentUser;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}