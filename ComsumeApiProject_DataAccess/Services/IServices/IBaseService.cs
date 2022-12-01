using ComsumeApiProject_Models.Dtos;
using ComsumeApiProject_Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeApiProject_DataAccess.Services.IServices
{
    public interface IBaseService:IDisposable
    {
        ResponseDto ResponseModel { get; set; }
        Task<T> SendAsync<T>(ApiRequest apiRequest);
    }
}
