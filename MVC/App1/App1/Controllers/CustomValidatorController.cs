using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App1.App_Code;
using App1.Models;

namespace App1.Controllers
{
    public class CustomValidatorController : Controller
    {
        // GET: CustomValidator
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Create([ModelBinder(typeof(LeaveForm2))] LeaveForm2 form)
        {
            if (ModelState.IsValid)
            {
                
            }
            return Json("haha");
        }

        public ActionResult DependencyInjection()
        {
            var service = ContainerCls.CreateService<DbService>();
            ViewBag.Result = service.GetType().ToString();
            ViewBag.Result = service.SearchAll();
            return View();
        }

    }
}