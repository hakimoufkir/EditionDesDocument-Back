using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Enums
{
    public class Roles
    {
        public enum roles
        {
            assistant,
            trainee,
            director,
        }

        public static class RolesPermission
        {
            public const string Permission = "You don't have permission!";

        }
    }
}
