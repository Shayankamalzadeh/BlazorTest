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
    [ApiController]
    [Route("api/users")]
    public class UserController : ControllerBase
    {

        static List<Role> roles = new List<Role>
        {
            new Role{Id=1,Caption="Admin"},
            new Role{Id=2,Caption="User"}
        };

        static List<User> users = new List<User> {
            new User {Id=1, Name = "Shayan", LastName = "Kamalzadeh", Email = "Shayankamalzadeh@gmail.com", Role = roles[0] ,RoleId=1 ,Password="123"} ,
            new User {Id=2, Name = "Andrie", LastName = "xxxx", Email = "xxxx@gmail.com", Role = roles[1],RoleId=2 ,Password="123"},
            new User {Id=3, Name = "Pooria", LastName = "Yyyy", Email = "YYYY@gmail.com", Role = roles[0],RoleId=1,Password="123"}
        };
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetUser()
        {
            return Ok(users);
        }


        [HttpGet("roles")]
        public async Task<IActionResult> GetRoles()
        {
            return Ok(roles);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> Getdetail(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            user.Id = users.Max(x => x.Id + 1);
            users.Add(user);
            return Ok(users);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> UpdateUser(User user)
        {
            var dbuser = users.FirstOrDefault(x => x.Id == user.Id);
            var index = users.IndexOf(dbuser);
            users[index] = user;
            return Ok(users);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var dbuser = users.FirstOrDefault(x => x.Id == id);

            users.Remove(dbuser);
            return Ok(users);
        }
    }
}
