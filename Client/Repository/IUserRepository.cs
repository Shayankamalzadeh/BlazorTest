using BlazorTest.Shared.Entities;
using BlazorTest.Shared.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Client.Repository
{
    public interface IUserRepository
    {
        Task<ResponseData<bool>> CreateUser(User user);
        Task<ResponseData<bool>> DeleteUser(User user);
        Task<ResponseData<List<User>>> GetAllUsers();
        Task<ResponseData<User>> GetUserById(long Id);
        Task<ResponseData<List<Role>>> Roles();
        Task<ResponseData<bool>> UpdateUser(User user);
    }
}
