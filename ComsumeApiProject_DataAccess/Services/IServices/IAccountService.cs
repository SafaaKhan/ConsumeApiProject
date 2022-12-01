using ComsumeApiProject_Models.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeApiProject_DataAccess.Services.IServices
{
    public interface IAccountService:IBaseService
    {
        //login
        Task<T> LoginAsync<T>(LoginDto loginDto);
        //register
        //get user
    }
}
