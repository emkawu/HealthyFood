using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Helpers
{
    public class UserRoles
    {
        public const string Admin = nameof(Admin);
        public const string User = nameof(User);

        public static List<string> UserRoleList { get; set; } = new List<string> { Admin, User };
    }
}
