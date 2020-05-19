using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using BProfTemaLab.Dal.SeedInterfaces;
using BProfTemaLab.Dal.Users;
using Microsoft.AspNetCore.Identity;

namespace BProfTemaLab.Dal.SeedService
{
    public class RoleSeedService :IRoleSeedService
    {
        private readonly RoleManager<IdentityRole<int>> _roleManager;
        public RoleSeedService(RoleManager<IdentityRole<int>> roleManager) =>
            _roleManager = roleManager;
        public async Task SeedRoleAsync()
        {
            if (!await _roleManager.RoleExistsAsync(Roles.Administrators))
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Administrators });

            if (!await _roleManager.RoleExistsAsync(Roles.Suppliers))
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Suppliers });

            if (!await _roleManager.RoleExistsAsync(Roles.Workers))
                await _roleManager.CreateAsync(new IdentityRole<int> { Name = Roles.Workers });
        }
    }
}
