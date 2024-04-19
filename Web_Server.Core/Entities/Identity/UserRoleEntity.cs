using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Web_Server.Core.Entities.Identity
{
    public class UserRoleEntity : IdentityUserRole<int>
    {
        public virtual UserEntity? User { get; set; }
        public virtual RoleEntity? Role { get; set; }
    }
}
