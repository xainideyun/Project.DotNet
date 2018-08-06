using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace App1.Controllers
{
    public class TaskController : Controller
    {
        private int num = 0;
        // GET: Task
        public ActionResult Index()
        {
            var arr = new[]
            {
                new Task(() => num++), new Task(() => num++), new Task(() => num++),
                new Task(() => num++), new Task(() => num++), new Task(() => num++), new Task(() => num++)
            };
            var result = Task.WaitAny(arr);
            return View();
        }

        public ActionResult F1()
        {

            return View();
        }

    }
}