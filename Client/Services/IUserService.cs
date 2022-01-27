using BlazorTest.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Client.Services
{
    public interface IUserService
    {
        event Action OnChange;
        List<Role> Roles { get; set; }
        List<User> Users { get; set; }
        Task GetRoles();
        Task<List<User>> GetUsers();
        Task<User> GetUserDetail(int id);

        Task<List<User>> CreateUser(User user);
    }
}
