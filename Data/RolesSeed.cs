//using EnumsNET;
//using Microsoft.AspNetCore.Identity;
//using MusicHub.Models.Identity;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;

//namespace MusicHub.Data
//{
//    public static class RolesSeed
//    {
//        public static async Task SeedRolesAsync(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
//        {
//            //Seed Roles
//            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Admin.ToString()));;
//            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Moderator.ToString()));
//            await roleManager.CreateAsync(new IdentityRole(Enums.Roles.Basic.ToString()));
//        }
//    }
//}
