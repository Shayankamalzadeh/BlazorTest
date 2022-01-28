using BlazorTest.Shared.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Client.Services
{
  public  interface IHttpService
    {
        Task<ResponseData<object>> PostAsync<T>(string url, T data);
        Task<ResponseData<TResponse>> PostAsync<T, TResponse>(string url, T data);
        Task<ResponseData<T>> Get<T>(string url);
    }
}
