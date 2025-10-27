using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Errors
{
    public class ApiErrorResponse(int statusCode, string message , string? details)
    {
        public int StatusCode { get; set; } = statusCode;
        public string Message { set; get; } = message;
        public string? Details { set; get; } = details;
    }
}