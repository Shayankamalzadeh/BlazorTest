using BlazorTest.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Server.Services
{
    public interface IUerService
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        void Create(User model);
        void Update(User model);
        void Delete(int id);

    }
}
