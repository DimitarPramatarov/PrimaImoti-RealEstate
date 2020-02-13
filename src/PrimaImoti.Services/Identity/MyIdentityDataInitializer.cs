using Microsoft.AspNetCore.Identity;
using PrimaImoti.DataModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace PrimaImoti.Services.Identity
{
    public static class MyIdentityDataInitializer
    {
        public static void SeedData
            (UserManager<PrimaImotiUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        public static  void SeedUsers
            (UserManager<PrimaImotiUser> userManager)
        {
            if(userManager.FindByNameAsync("dimitar").Result == null)
            {
                PrimaImotiUser user = new PrimaImotiUser();
                user.UserName = "dimitar";
                var adminPassword = "pramatarov";

                IdentityResult result = userManager.CreateAsync
                    (user, adminPassword).Result;

                if(result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "Admin").Wait();
                }
            }

            if(userManager.FindByEmailAsync("test@test.com").Result == null)
            {
                PrimaImotiUser user = new PrimaImotiUser();
                user.UserName = "User";

                var password = "userpass";
                    
                IdentityResult result = userManager.CreateAsync
                    (user, password).Result;

                if(result.Succeeded)
                {
                    userManager.AddToRoleAsync(user, "User").Wait();
                }
            }

        }

        public static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if(!roleManager.RoleExistsAsync("User").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "User";
                role.NormalizedName = "USER";
                IdentityResult roleResult = roleManager
                    .CreateAsync(role).Result;
            }

            if(!roleManager.RoleExistsAsync("Admin").Result)
            {
                IdentityRole role = new IdentityRole();
                role.Name = "Admin";
                role.NormalizedName = "ADMIN";
                
                IdentityResult roleResult = roleManager
                    .CreateAsync(role).Result;

            }
        }
    }
}
