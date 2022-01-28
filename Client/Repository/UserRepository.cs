using BlazorTest.Client.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Client.Repository
{
    public class UserRepository
    {
        private readonly IHttpService _http;
        private readonly string _URL = "api/users";
    }
}
