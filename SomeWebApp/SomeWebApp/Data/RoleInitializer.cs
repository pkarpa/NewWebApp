using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SomeWebApp.Data
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(UserManager<IdentityUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            string UserAdminEmail = "UserAdmin@gmail.com";
            string UserAdminPassword = "_Aa123456UserAdmin";

            string ShopAdminEmail = "ShopAdmin@gmail.com";
            string ShopAdminPassword = "_Aa123456ShopAdmin";

            string UserAdminRole = "user admin";
            string ShopAdminRole = "shop admin";
            string UserRole = "user";
            if (await roleManager.FindByNameAsync(UserAdminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(UserAdminRole));
            }
            if (await roleManager.FindByNameAsync(ShopAdminRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(ShopAdminRole));
            }
            if (await roleManager.FindByNameAsync(UserRole) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(UserRole));
            }
            if (await userManager.FindByNameAsync(UserAdminEmail) == null)
            {
                IdentityUser UserAdmin = new IdentityUser { UserName = "MarkUserAdmin", Email = UserAdminEmail };
                IdentityResult result = await userManager.CreateAsync(UserAdmin, UserAdminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(UserAdmin, UserAdminRole);
                }
            }
            if (await userManager.FindByNameAsync(ShopAdminEmail) == null)
            {
                IdentityUser ShopAdmin = new IdentityUser { UserName = "JackShopAdmin", Email = ShopAdminEmail };
                IdentityResult result = await userManager.CreateAsync(ShopAdmin, ShopAdminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(ShopAdmin, ShopAdminRole);
                }
            }
           
        }
    }
}
