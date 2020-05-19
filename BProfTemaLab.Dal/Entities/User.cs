using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace BProfTemaLab.Dal.Entities
{
   public class User : IdentityUser<int>
    {
        public string Name { get; set; }
    }
}
