using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App1.Models;

namespace App1.Controllers
{
    public class M1Controller : Controller
    {
        [Authorize]
        // GET: M1
        public ActionResult Index([Bind(Include = "Name, Age")]Person person)
        {



            return View(new[] { new Person { Name = "孙小双", Age = 29 }, new Person { Name = "李怡然", Age = 27 } });
        }

        public ActionResult Part1()
        {
            return View();
        }

        // GET: M1/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: M1/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: M1/Create
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

        // GET: M1/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: M1/Edit/5
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

        // GET: M1/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: M1/Delete/5
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
