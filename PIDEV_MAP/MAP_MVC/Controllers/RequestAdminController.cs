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

namespace MAP_MVC.Controllers
{
    public class RequestAdminController : Controller
    {
        private MapContext db = new MapContext();

        // GET: RequestAdmin
        public ActionResult Index(string sortOrder)
        {


            ViewBag.DepDateSortParm = String.IsNullOrEmpty(sortOrder) ? "depdate_desc" : "";
            ViewBag.DebDateSortParm = String.IsNullOrEmpty(sortOrder) ? "debdate_desc" : "";
            ViewBag.EndDateSortParm = String.IsNullOrEmpty(sortOrder) ? "enddate_desc" : "";

            var dates = from s in db.RequestS
                        select s;



            switch (sortOrder)
            {
                case "depdate_desc":
                    dates = dates.OrderByDescending(s => s.DateDeposit);
                    break;
                case "debdate_desc":
                    dates = dates.OrderBy(s => s.DateStart_Mandat);
                    break;
                case "enddate_desc":
                    dates = dates.OrderByDescending(s => s.DateEnd_Mandat);
                    break;
                default:
                    dates = dates.OrderBy(s => s.DateDeposit);
                    break;
            }



         /*   if (sortOrder == "depdate_desc")

                dates = dates.OrderByDescending(s => s.DateDeposit);*/
            return View(dates.ToList());
        }

        // GET: RequestAdmin/Details/5
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

       

        // GET: RequestAdmin/Edit/5
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

        // POST: RequestAdmin/Edit/5
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
