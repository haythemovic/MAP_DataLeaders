using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using static PIDEV_MAP.Domain.entities.User;
using PIDEV_MAP.Domain.entities;

namespace PIDEV_MAP.Data
{
    public class CustomUserStore : UserStore<User, CustomRole, int, CustomUserLogin, CustomUserRole, CustomUserClaim>
    {
        public CustomUserStore(DbContext context) : base(context)
        {
        }
    }
}
