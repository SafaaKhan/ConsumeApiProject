using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeApiProject_Models.Dtos
{
    public class ResponseDto
    {
        public bool IsSeccuss { get; set; }
        public object Value { get; set; }
        public string DisplayMessage { get; set; }
        public List<string> ErrorMessages { get; set; }=new List<string> { string.Empty};
        public int StatusCode { get; set; }
    }
}
