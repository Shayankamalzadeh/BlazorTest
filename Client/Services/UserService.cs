using BlazorTest.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorTest.Client.Services
{
    public class UserService : IUserService
    {
        private readonly HttpClient httpClient;
        public UserService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public List<Role> Roles { get; set; } = new List<Role>();
        public List<User> Users { get; set; } = new List<User>();

        public event Action OnChange;

        public async Task<List<User>> CreateUser(User user)
        {
            var result = await httpClient.PostAsJsonAsync($"api/user", user);
            Users = await result.Content.ReadFromJsonAsync<List<User>>();
            OnChange.Invoke();
            return Users;
        }

        public async Task GetRoles()
        {
            Roles = await httpClient.GetFromJsonAsync<List<Role>>("api/user/roles");
        }

        public async Task<User> GetUserDetail(int id)
        {
            return await httpClient.GetFromJsonAsync<User>($"api/user/{id}");
        }

        public async Task<List<User>> GetUsers()
        {
            Users = await httpClient.GetFromJsonAsync<List<User>>("api/user");
            return Users;
        }
    }
}
