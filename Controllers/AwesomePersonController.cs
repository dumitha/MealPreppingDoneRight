using MealPreppingDoneRight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.Web.Mvc;

namespace MealPreppingDoneRight.Controllers
{
    public class AwesomePersonController : Controller
    {
        // GET: AwesomePersonUsers
        public ActionResult AwesomePersonIndex()
        {
           var  awesomePerson = new AwesomePerson();

            awesomePerson.AweesomeName = "Carrie";
            
            return View("AwesomePersonIndex", awesomePerson);
        }

        // GET: AwesomePersonUsers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AwesomePersonUsers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AwesomePersonUsers/Create
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

        // GET: AwesomePersonUsers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AwesomePersonUsers/Edit/5
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

        // GET: AwesomePersonUsers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AwesomePersonUsers/Delete/5
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
