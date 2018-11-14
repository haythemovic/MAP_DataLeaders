using PIDEV_MAP.Domain.entities;
using PIDEV_MAP.Service.Services.Implementation;
using PIDEV_MAP.Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MAP_MVC.Controllers
{
    public class MandatController : Controller
    {

        private IRessource_MandatService Res_MandatService = null;

        public MandatController()
        {
            Res_MandatService = new Ressource_MandatService();
        }




        // GET: Mandat
        public ActionResult Index()
        {
            // var ResourceDomain = Res_MandatService.GetMany();
            var ResourceDomain = Res_MandatService.listResource();
            List<MAP_MVC.Models.User> ListViewModel = new List<MAP_MVC.Models.User>();
            foreach (var f in ResourceDomain)
            {
                ListViewModel.Add(new MAP_MVC.Models.User
                {
                    //Id=f.Id,
                    FirstName = f.FirstName,
                    LastName = f.LastName,
                    //Email=f.Email,
                    // bussniesprofile = f.bussniesprofile,
                    // Gender = f.Gender
                    // Availblilty = f.Availblilty,


                });
            }

            return View(ListViewModel.ToList());
        }

        // GET: Mandat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Mandat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Mandat/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Mandat/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Mandat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Mandat/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
