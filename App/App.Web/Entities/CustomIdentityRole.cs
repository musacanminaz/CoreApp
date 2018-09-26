using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace App.Web.Entities
{
    public class CustomIdentityRole : IdentityRole
    {
        public CustomIdentityRole(string roleName) : base(roleName)
        {
        }
    }
}
