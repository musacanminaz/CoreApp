using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace App.Web.Identity
{
    public class AppIdentityRole : IdentityRole
    {
        public AppIdentityRole(string roleName) : base(roleName)
        {
        }
    }
}
