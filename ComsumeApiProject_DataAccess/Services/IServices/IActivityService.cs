using ComsumeApiProject_Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeApiProject_DataAccess.Services.IServices
{
    public interface IActivityService:IBaseService
    {
        Task<T> GetActivitesAsync<T>(string accessToken);
        Task<T> GetActivityByIdAsync<T>(string Id, string accessToken);
        Task<T> CreateActivityAsync<T>(PostActivityDto activityDto, string accessToken);
        Task<T> UpdateActivityAsync<T>(ActivityDto activityDto, string accessToken);
        Task<T> DeleteActivityAsync<T>(string Id, string accessToken);
    }
}
