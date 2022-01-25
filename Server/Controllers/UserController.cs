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

        List<User> users = new List<User> {
            new User {Id=1, Name = "Shayan", LastName = "Kamalzadeh", Email = "Shayankamalzadeh@gmail.com", Role = roles[0] } ,
            new User {Id=2, Name = "Andrie", LastName = "xxxx", Email = "xxxx@gmail.com", Role = roles[1] },
            new User {Id=3, Name = "Pooria", LastName = "Yyyy", Email = "YYYY@gmail.com", Role = roles[0] }
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
        [HttpGet("{id}")]
        public async Task<IActionResult> Getdetail(int id)
        {
            var user = users.FirstOrDefault(x => x.Id == id);
            return Ok(user);
        }
    }
}
