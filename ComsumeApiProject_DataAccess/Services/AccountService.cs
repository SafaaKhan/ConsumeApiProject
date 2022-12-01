using ComsumeApiProject_DataAccess.Services.IServices;
using ComsumeApiProject_Models.Dtos;
using ComsumeApiProject_Models.Models;
using ComsumeApiProject_Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeApiProject_DataAccess.Services
{
    public class AccountService : BaseService, IAccountService
    {
        private readonly IHttpClientFactory _httpClient;

        public AccountService(IHttpClientFactory httpClient):base(httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<T> LoginAsync<T>(LoginDto loginDto)
        {
            return await SendAsync<T>(new ApiRequest
            {
                AccessToken="",
                ApiType=SD.ApiType.POST,
                Value=loginDto,
                URL=SD.ActivityAPIBase+ "api/Account/login"
            });
        }
    }
}
