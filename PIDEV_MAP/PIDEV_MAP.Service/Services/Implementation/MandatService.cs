using PIDEV_MAP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;
using PIDEV_MAP.Service.Services.Interfaces;
using PIDEV_MAP.Domain.entities;

namespace PIDEV_MAP.Service.Services.Implementation
{
    public class MandatService : Service<Mandat>, IMandatService
    {

        private static IDataBaseFactory databaseFactory = new DataBaseFactory();
        private static IUnitOfWork unitOfWork = new UnitOfWork(databaseFactory);

        public MandatService(IUnitOfWork utwk) : base(utwk)
        {

        }
    }
}
