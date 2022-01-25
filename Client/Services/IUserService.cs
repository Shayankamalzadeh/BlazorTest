using BlazorTest.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Client.Services
{
    public interface IUserService
    {
        public Task<List<User>> GetUsers();
    }
}
