using HealthyFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Services
{
    public interface IUserRepository
    {
        IEnumerable<ApplicationUser> GetAllUsers();
        ApplicationUser GetUser(string id);
    }
}
