using HealthyFood.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Data
{
    public class SampleData
    {
        private readonly ApplicationDbContext _context;

        public SampleData(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async void SeedAdminUser()
        {
            var user = new ApplicationUser
            {
                UserName = "admin@healthyfood.com",
                Email = "admin@healthyfood.com",
                NormalizedEmail = "admin@healthyfood.com".ToUpper(),
                NormalizedUserName = Helpers.UserRoles.Admin.ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false,
                LockoutEnabled = false,
                SecurityStamp = Guid.NewGuid().ToString()
            };

            var roleStore = new RoleStore<IdentityRole>(_context);

            if (!_context.Roles.Any(r => r.Name == "admin"))
            {
                await roleStore.CreateAsync(new IdentityRole { Name = "admin", NormalizedName = "admin" });
            }

            if (!_context.Users.Any(u => u.UserName == user.UserName))
            {
                var password = new PasswordHasher<ApplicationUser>();
                var hashed = password.HashPassword(user, "password");
                user.PasswordHash = hashed;
                var userStore = new UserStore<ApplicationUser>(_context);
                await userStore.CreateAsync(user);
                await userStore.AddToRoleAsync(user, "admin");
            }

            await _context.SaveChangesAsync();
        }

    }
}
