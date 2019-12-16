using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Data;
using HealthyFood.Models;

namespace HealthyFood.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;

        public UserRepository(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public ApplicationUser GetUser(string id)
        {
            throw new NotImplementedException();
        }
    }
}
