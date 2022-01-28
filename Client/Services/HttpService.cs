using BlazorTest.Shared.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Client.Services
{
    public class HttpService : IHttpService
    {
        public Task<ResponseData<T>> Get<T>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseData<object>> PostAsync<T>(string url, T data)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseData<TResponse>> PostAsync<T, TResponse>(string url, T data)
        {
            throw new NotImplementedException();
        }
    }
}
