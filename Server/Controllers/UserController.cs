using BlazorTest.Shared.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        static List<Role> roles = new List<Role>
        {
            new Role{Id=1,Caption="Admin"},
            new Role{Id=2,Caption="User"}
        };
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<User> Get()
        {


            List<User> users = new List<User>();
            users.Add(new User { Name = "Shayan", LastName = "Kamalzadeh", Email = "Shayankamalzadeh@gmail.com", Role = roles[0] });
            users.Add(new User { Name = "Andrie", LastName = "xxxx", Email = "xxxx@gmail.com", Role = roles[1] });
            users.Add(new User { Name = "Pooria", LastName = "Yyyy", Email = "YYYY@gmail.com", Role = roles[0] });

            return users;
        }

    }
}
