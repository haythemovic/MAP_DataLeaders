using Data.Infrastructure;
using PIDEV_MAP.Data;
using PIDEV_MAP.Domain.entities;
using PIDEV_MAP.Service.Services.Interfaces;
using PIDEV_MAP.ServicePattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PIDEV_MAP.Service.Services.Implementation
{
   public class RequestService : Service<Request>, IRequestService
    {
        private static IDataBaseFactory databaseFactory = new DataBaseFactory();
        private static IUnitOfWork utk = new UnitOfWork(databaseFactory);

        public RequestService() : base(utk)
        {
        }

        public List<Request> GetByUserID(int IdUser)
        {
           MapContext db = new MapContext();
        //  return _repository.GetAll();
        List<Request> list = db.RequestS.ToList();
            List<Request> list2 = new List<Request>()  ;
            foreach (Request req in list )
            {          
                if (req.userId == IdUser)
                {
                    list2.Add(req);
                }
            }
            return list2;
        }


        public Boolean DateCorrect(Request R)
        {
            int a = DateTime.Compare(R.DateEnd_Mandat, R.DateStart_Mandat);
            if (a < 0)
               return false;
            else return true;
        }

    }
}
