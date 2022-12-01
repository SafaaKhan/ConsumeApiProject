using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ComsumeApiProject_Utilities.SD;

namespace ComsumeApiProject_Models.Models
{
    public class ApiRequest
    {
        //apitype
        public ApiType ApiType { get; set; } = ApiType.GET;
        //url
        public string URL { get; set; }
        //data
        public object Value { get; set; } //post put
        //accesstoken
        public string  AccessToken{ get; set; }
    }
}
