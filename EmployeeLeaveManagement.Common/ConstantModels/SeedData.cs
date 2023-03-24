using EmployeeLeaveManagement.Data.DbModels;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLeaveManagement.Common.ConstantModels
{
    public static class SeedData
    {
        public static void Seed(UserManager<Employee> userManager, RoleManager<IdentityRole> roleManager)
        {
            SeedRoles(roleManager);
            SeedUsers(userManager);
        }

        private static void SeedUsers(UserManager<Employee> userManager)
        {
            if (userManager.FindByNameAsync(ResultConstants.Admin_Email).Result == null)
            {
                var user = new Employee
                {
                    UserName = ResultConstants.Admin_Email,
                    Email = ResultConstants.Admin_Email
                };
                var result = userManager.CreateAsync(user, ResultConstants.Admin_Password).Result;
                if (result.Succeeded)
                    userManager.AddToRoleAsync(user, ResultConstants.Admin_Role);
            }
        }


        private static void SeedRoles(RoleManager<IdentityRole> roleManager)
        {
            if (!roleManager.RoleExistsAsync(ResultConstants.Admin_Role).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstants.Admin_Role
                };
                var result = roleManager.CreateAsync(role).Result;
            }
            if (!roleManager.RoleExistsAsync(ResultConstants.Employee_Role).Result)
            {
                var role = new IdentityRole
                {
                    Name = ResultConstants.Employee_Role
                };
                var result = roleManager.CreateAsync(role).Result;
            }
        }
    }
}