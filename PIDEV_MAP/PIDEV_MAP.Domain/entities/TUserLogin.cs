﻿using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Domain.entities
{
  public  class TUserLogin : IdentityUserRole<int>
    {
        public int TUserLoginId { get; set; }
    }
}