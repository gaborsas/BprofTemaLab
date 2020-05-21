using System;
using System.Collections.Generic;
using BProfTemaLab.Dal.Entities;
using System.Text;
using System.Linq;

namespace BProfTemaLab.Dal.Services
{
    public class UserService
    {
        public UserService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }

        public IEnumerable<User> GetUsers() => DbContext.Users.ToList();

    }
}
