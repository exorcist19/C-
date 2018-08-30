using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentMyWrox.Models;

namespace RentMyWrox.Controllers
{
    public class UseDemoGraphicsController : Controller
    {
        // GET: UseDemoGraphics
        public ActionResult Index()
        {
            return View();
        }

        // GET: UseDemoGraphics/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UseDemoGraphics/Create
        public ActionResult Create()
        {
            return View("Manage");
        }

        // POST: UseDemoGraphics/Create
        [HttpPost]
        public ActionResult Create(UseDemoGraphics obj)
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

        // GET: UseDemoGraphics/Edit/5
        public ActionResult Edit(int id)
        {
            var model = new UseDemoGraphics
            {
                Gender = "Male",
                BirthDate = new DateTime(2000, id, id),
                MaritalStatus = "Married",
                OwnHome = true,
                TotalPeopleInHome = id,
                Hobbies = new List<string> { "Gardening", "Other" }
            };
            return View("Manage", model);
        }

        // POST: UseDemoGraphics/Edit/5
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

        // GET: UseDemoGraphics/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UseDemoGraphics/Delete/5
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
