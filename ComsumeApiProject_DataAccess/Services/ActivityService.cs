using ComsumeApiProject_DataAccess.Services.IServices;
using ComsumeApiProject_Models.Dtos;
using ComsumeApiProject_Models.Models;
using ComsumeApiProject_Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComsumeApiProject_Utilities.SD;

namespace ComsumeApiProject_DataAccess.Services
{
    public class ActivityService : BaseService, IActivityService
    {
        private readonly IHttpClientFactory _httpClient;

        public ActivityService(IHttpClientFactory httpClient):base(httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> CreateActivityAsync<T>(PostActivityDto activityDto, string accessToken)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken= accessToken,
                ApiType= ApiType.POST,
                URL=SD.ActivityAPIBase+ "api/Activites",
                Value=activityDto
            });
        }

        public async Task<T> DeleteActivityAsync<T>(string Id, string accessToken)
        {
           return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = accessToken,
                ApiType = ApiType.DELETE,
                URL = SD.ActivityAPIBase + "api/Activites/"+Id
            });
        }

        public async Task<T> GetActivitesAsync<T>(string accessToken)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = accessToken,
                ApiType = ApiType.GET,
                URL = SD.ActivityAPIBase + "api/Activites/" 
            });
        }

        public async Task<T> GetActivityByIdAsync<T>(string Id, string accessToken)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = accessToken,
                ApiType = ApiType.GET,
                URL = SD.ActivityAPIBase + "api/Activites/" + Id
            });
        }

        public async Task<T> UpdateActivityAsync<T>(ActivityDto activityDto, string accessToken)
        {
            return await SendAsync<T>(new ApiRequest()
            {
                AccessToken = accessToken,
                ApiType = ApiType.PUT,
                URL = SD.ActivityAPIBase + "api/Activites",
                Value = activityDto
            });
        }
    }
}
