using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MealPreppingDoneRight.Controllers
{
    public class HealthyMealController : Controller
    {
        // GET: HealthyMeal
        public ActionResult Index()
        {
            return View();
        }

        // GET: HealthyMeal/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HealthyMeal/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HealthyMeal/Create
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

        // GET: HealthyMeal/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HealthyMeal/Edit/5
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

        // GET: HealthyMeal/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HealthyMeal/Delete/5
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
