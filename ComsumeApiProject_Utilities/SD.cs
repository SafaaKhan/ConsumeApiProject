using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComsumeApiProject_Utilities
{
    public static class SD //static details
    {
        public static string ActivityAPIBase { set; get; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

    }
}
