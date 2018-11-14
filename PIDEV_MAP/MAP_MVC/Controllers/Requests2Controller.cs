using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PIDEV_MAP.Data;
using PIDEV_MAP.Domain.entities;
using Microsoft.AspNet.Identity;
using PIDEV_MAP.Service.Services.Implementation;

namespace MAP_MVC.Controllers
{
    public class Requests2Controller : Controller
    {
        private MapContext db = new MapContext();
        RequestService reqS = new RequestService();
        UserService UserServ = new UserService();


        // GET: Requests2
        public ActionResult Index()
        {

            return View(reqS.GetByUserID(Int32.Parse(User.Identity.GetUserId())));
        }

        // GET: Requests2/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = db.RequestS.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // GET: Requests2/Create
        public ActionResult Create()
        {

            IEnumerable<User> AllUser = UserServ.GetMany();
            // IList<User> userC = null;
            List<User> userss = new List<User>();
            foreach (User u in AllUser)
            {
                if (u.Role == "Customer")
                {
                    //  userC.Concat(new[] u);
                  //  Customer customer = (Customer)u;
                    userss.Add(u);
                }
            }
            //ViewBag.data = userC;
            //ViewBag.Users = UserServ.GetMany();
            ViewBag.Users = userss;
            return View();
            
        }

        // POST: Requests2/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RequestID,requiredProfile,NbRequiredProfile,yearExperience,Education,DateStart_Mandat,DateEnd_Mandat")] Request request)
        {
            if (ModelState.IsValid)
            {
                System.Security.Principal.WindowsIdentity.GetCurrent();
                request.stateRequest = StateRequest.Pending ;
                request.DateDeposit = DateTime.Now;
                request.userId = Int32.Parse(User.Identity.GetUserId());
                if (reqS.DateCorrect(request)) {
                db.RequestS.Add(request);
                db.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            return View(request);
        }

        // GET: Requests2/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = db.RequestS.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Requests2/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RequestID,requiredProfile,NbRequiredProfile,yearExperience,Education,DateDeposit,DateStart_Mandat,DateEnd_Mandat,stateRequest,userId")] Request request)
        {
            if (ModelState.IsValid)
            {
                db.Entry(request).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(request);
        }

        // GET: Requests2/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Request request = db.RequestS.Find(id);
            if (request == null)
            {
                return HttpNotFound();
            }
            return View(request);
        }

        // POST: Requests2/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Request request = db.RequestS.Find(id);
            db.RequestS.Remove(request);
            db.SaveChanges();
            return RedirectToAction("Index");
        }







        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
