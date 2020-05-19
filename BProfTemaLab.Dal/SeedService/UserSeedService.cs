using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BProfTemaLab.Dal.Entities;
using BProfTemaLab.Dal.SeedInterfaces;
using BProfTemaLab.Dal.Users;
using Microsoft.AspNetCore.Identity;

namespace BProfTemaLab.Dal.SeedService
{
    public class UserSeedService: IUserSeedService
    {
        private readonly UserManager<User> _userManager;
        public UserSeedService(UserManager<User> userManager) =>
            _userManager = userManager;
        public async Task SeedUserAsync()
        {
            if (!(await _userManager.GetUsersInRoleAsync(Roles.Administrators)).Any())
            {
                var user = new User
                {
                    Email = "admin@bprofstand.hu",
                    Name = "TesztAdmin",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "admin"
                };
                var createResult = await _userManager.CreateAsync(user, "Asdasd123!");
                var addToRoleResult = await _userManager.AddToRoleAsync(user, Roles.Administrators);
                if (!createResult.Succeeded || !addToRoleResult.Succeeded)
                    throw new ApplicationException($"Administrator could not be created: " +
                                                   $"{string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(e => e.Description))}");
            }

            if (!(await _userManager.GetUsersInRoleAsync(Roles.Suppliers)).Any())
            {
                var user = new User
                {
                    Email = "supplier@bprofstand.hu",
                    Name = "Teszt_Supplier",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "supplier"
                };
                var createResult = await _userManager.CreateAsync(user, "Asdasd123!");
                var addToRoleResult = await _userManager.AddToRoleAsync(user, Roles.Suppliers);
                if (!createResult.Succeeded || !addToRoleResult.Succeeded)
                    throw new ApplicationException($"Supplier could not be created: " +
                                                   $"{string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(e => e.Description))}");
            }

            if (!(await _userManager.GetUsersInRoleAsync(Roles.Workers)).Any())
            {
                var user = new User
                {
                    Email = "worker@bprofstand.hu",
                    Name = "Teszt_Worker",
                    SecurityStamp = Guid.NewGuid().ToString(),
                    UserName = "worker"
                };
                var createResult = await _userManager.CreateAsync(user, "Asdasd123!");
                var addToRoleResult = await _userManager.AddToRoleAsync(user, Roles.Workers);
                if (!createResult.Succeeded || !addToRoleResult.Succeeded)
                    throw new ApplicationException($"Worker could not be created: " +
                                                   $"{string.Join(", ", createResult.Errors.Concat(addToRoleResult.Errors).Select(e => e.Description))}");
            }
        }

    }
}
