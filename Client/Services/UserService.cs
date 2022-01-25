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

        public async Task<List<User>> GetUsers()
        {
            return await httpClient.GetFromJsonAsync<List<User>>("api/user");
        }
    }
}
