using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HealthyFood.Data;
using HealthyFood.Models;
using Microsoft.AspNetCore.Identity;
using HealthyFood.Helpers;

namespace HealthyFood.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
        }

        public IEnumerable<ApplicationUser> GetAllUsers()
        {
            return _userManager.GetUsersInRoleAsync(UserRoles.User).Result;
        }

        public async Task<IEnumerable<ApplicationUser>> GetAllUsersAsync()
        {
            return await _userManager.GetUsersInRoleAsync(UserRoles.User);
        }

        public ApplicationUser GetUser(string userId)
        {
            if (userId == null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            return _context.Users
              .Where(u => u.Id == userId).FirstOrDefault();
        }
    }
}
