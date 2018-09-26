using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace App.Web.Entities
{
    public class RoleInitializer
    {
        public static async Task Initial(RoleManager<CustomIdentityRole> roleManager)
        {
            if (!await roleManager.RoleExistsAsync("Admin"))
            {
                var users = new CustomIdentityRole("Admin");
                await roleManager.CreateAsync(users);
            }

            if (!await roleManager.RoleExistsAsync("Manager"))
            {
                var users = new CustomIdentityRole("Manager");
                await roleManager.CreateAsync(users);
            }

            if (!await roleManager.RoleExistsAsync("Editor"))
            {
                var users = new CustomIdentityRole("Editor");
                await roleManager.CreateAsync(users);
            }

            if (!await roleManager.RoleExistsAsync("Customer"))
            {
                var users = new CustomIdentityRole("Customer");
                await roleManager.CreateAsync(users);
            }

        }
    }
}
