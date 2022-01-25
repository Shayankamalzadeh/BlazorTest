using BlazorTest.Shared.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorTest.Server.Services
{
    public interface IUserService
    {
         Task<List<User>> GetUsers();
    }
}
