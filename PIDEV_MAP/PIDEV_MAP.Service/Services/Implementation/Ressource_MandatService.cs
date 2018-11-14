using PIDEV_MAP.Domain.entities;
using PIDEV_MAP.Service.Services.Interfaces;
using PIDEV_MAP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Infrastructure;

namespace PIDEV_MAP.Service.Services.Implementation
{
    public class Ressource_MandatService : Service<User>, IRessource_MandatService
    {

        private static IDataBaseFactory databaseFactory = new DataBaseFactory();
        private static IUnitOfWork unitOfWork = new UnitOfWork(databaseFactory);

      

        public Ressource_MandatService() :base(unitOfWork)
        {
        }

      /*  public User GetResourceByAvailibilty(string Availibility)
        {
            var Resource = (from t in unitOfWork.getRepository<User>().GetMany()
                       where t.Availibility == Availibility
                            select t).FirstOrDefault();
            return Resource ?? null;
        }*/ //à compléter !!

        public IEnumerable<User> listResource()
        {
            IEnumerable<User> Resources = from User in unitOfWork.getRepository<User>().GetMany()
                                          where User.Role== "Resource"
                                          select User;

            return Resources;
        }
    }
}
