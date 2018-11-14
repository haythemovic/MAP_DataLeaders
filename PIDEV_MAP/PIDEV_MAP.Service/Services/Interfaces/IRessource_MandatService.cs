﻿using PIDEV_MAP.Domain.entities;
using PIDEV_MAP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Service.Services.Interfaces
{
    public interface IRessource_MandatService: IService<User>, IDisposable
    {
      IEnumerable<User> listResource();
        //User GetResourceByAvailibilty(string Availibility);
    }
}