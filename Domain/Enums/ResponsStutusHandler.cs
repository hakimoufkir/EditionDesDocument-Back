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

        }
    }
}
