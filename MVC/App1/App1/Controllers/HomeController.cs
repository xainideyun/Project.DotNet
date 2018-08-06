using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using App1.App_Start;

namespace App1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
//            return View();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        public JsonResult PostData(string name, string uri)
        {
            return Json(new { name = name, uri = uri });
        }

        public ActionResult Cors()
        {
            return View();
        }

        [HttpPost, CorsFilter]
        public JsonResult CorsPost()
        {
//            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return Json(new { name = "李怡然", age = 28 });
        }

        public ActionResult SsePage()
        {
            return View();
        }

        public void SSE()
        {
            Response.ContentType = "text/event-stream";
            Response.CacheControl = "no-cache";
            Response.Write("data:李怡然\n\n");
            Response.Flush();
        }

    }
}