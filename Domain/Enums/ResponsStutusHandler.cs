using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public class ResponsStutusHandler
    {
        public enum Status
        {
            RequestNotFound,
            BadRequest,
            Success,
            InternalServerError,
            Added,

        }
        public static class StatusMessages
        {
            public const string RequestNotFound = "Request not found";
            public const string BadRequest = "Bad request";
            public const string Success = "Success";
            public const string InternalServerError = "Internal server error";
            public const string Added = "Request added successfully!";
        }

      
    }
}
