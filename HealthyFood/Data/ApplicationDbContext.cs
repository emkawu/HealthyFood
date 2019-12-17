using HealthyFood.Entities;
using HealthyFood.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthyFood.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Day> Days { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Link_Day_Meal> Link_Day_Meals { get; set; }
        public DbSet<Link_Meal_Ingredient> Link_Meal_Ingredients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed categories
            modelBuilder.Entity<Category>().HasData(new Category { Cat_CatId = new Guid("4879aa16f9f14b519124d00a9d5637ca"), Cat_Name = "Category 1", Cat_Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Donec auctor pretium eros, sed mollis lectus blandit sit amet. Vivamus finibus iaculis ligula vitae sodales. Fusce hendrerit blandit molestie. Morbi quis leo lacus." });
            modelBuilder.Entity<Category>().HasData(new Category { Cat_CatId = new Guid("42e6406b1aec44f295037109cd9b11d2"), Cat_Name = "Category 2", Cat_Desc = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nam aliquet, massa quis pellentesque consequat, nunc lectus blandit elit, eget fringilla lorem ante at nulla." });
            modelBuilder.Entity<Category>().HasData(new Category { Cat_CatId = new Guid("a872b4affe874b6ab9fee57ad2c23184"), Cat_Name = "Category 3", Cat_Desc = "Pellentesque velit felis, sagittis lacinia lacinia sit amet, venenatis ut urna. Donec elit mi, ornare non rhoncus in, elementum et mi. Donec eleifend placerat massa, pretium aliquam diam mattis in." });

            //seed ADMIN
            ApplicationUser appAdmin = new ApplicationUser
            {
                UserName = "admin@healthyfood.com",
                Email = "admin@healthyfood.com",
                NormalizedEmail = "admin@healthyfood.com".ToUpper(),
                NormalizedUserName = Helpers.UserRoles.Admin.ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            ApplicationUser appUser = new ApplicationUser
            {
                UserName = "user@healthyfood.com",
                Email = "user@healthyfood.com",
                NormalizedEmail = "user@healthyfood.com".ToUpper(),
                NormalizedUserName = Helpers.UserRoles.User.ToUpper(),
                TwoFactorEnabled = false,
                EmailConfirmed = true,
                PhoneNumber = "123456789",
                PhoneNumberConfirmed = false
            };

            PasswordHasher<ApplicationUser> ph = new PasswordHasher<ApplicationUser>();
            appAdmin.PasswordHash = ph.HashPassword(appAdmin, "ZAQ123wsx!");
            PasswordHasher<ApplicationUser> phr = new PasswordHasher<ApplicationUser>();
            appUser.PasswordHash = phr.HashPassword(appUser, "ZAQ123wsx!");

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
            );
            modelBuilder.Entity<ApplicationUser>().HasData(appAdmin);
            modelBuilder.Entity<ApplicationUser>().HasData(appUser);
        }
    }
}
