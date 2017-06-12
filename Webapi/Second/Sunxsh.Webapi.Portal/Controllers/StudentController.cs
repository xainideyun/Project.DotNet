using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using Sunxsh.Webapi.Portal.Models;
namespace Sunxsh.Webapi.Portal.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            IEnumerable<StudentViewModel> students = new List<StudentViewModel>();
            using (HttpClient hc = new HttpClient())
            {
                hc.BaseAddress = new Uri("http://localhost/second/api/");
                var task = hc.GetAsync("Students");
                task.Wait();
                if (task.Result.IsSuccessStatusCode)
                {
                    var resultTask = task.Result.Content.ReadAsAsync<IEnumerable<StudentViewModel>>();
                    resultTask.Wait();
                    students = resultTask.Result;
                }
            }
            return View(students);
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            StudentViewModel student = new StudentViewModel();
            using (HttpClient hc = new HttpClient())
            {
                hc.BaseAddress = new Uri("http://localhost/second/api/");
                var task = hc.GetAsync($"Students?id={id}");
                task.Wait();
                if (task.Result.IsSuccessStatusCode)
                {
                    var resultTask = task.Result.Content.ReadAsAsync<StudentViewModel>();
                    resultTask.Wait();
                    student = resultTask.Result;
                }
            }
            return View(student);
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Student/Create
        [HttpPost]
        public ActionResult Create(StudentViewModel student)
        {
            try
            {
                using (HttpClient hc = new HttpClient())
                {
                    hc.BaseAddress = new Uri("http://localhost/second/api/");
                    var task = hc.PostAsJsonAsync("Students", student);
                    task.Wait();
                    if (task.Result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                ModelState.AddModelError(string.Empty, "Server Error. Please contact administrator.");
                return View(student);
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            StudentViewModel student = new StudentViewModel();
            using (HttpClient hc = new HttpClient())
            {
                hc.BaseAddress = new Uri("http://localhost/second/api/");
                var task = hc.GetAsync($"Students?id={id}");
                task.Wait();
                if (task.Result.IsSuccessStatusCode)
                {
                    var resultTask = task.Result.Content.ReadAsAsync<StudentViewModel>();
                    resultTask.Wait();
                    student = resultTask.Result;
                }
            }
            return View(student);
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(StudentViewModel student)
        {
            try
            {
                using (HttpClient hc = new HttpClient())
                {
                    hc.BaseAddress = new Uri("http://localhost/second/api/");
                    var task = hc.PutAsJsonAsync<StudentViewModel>($"Students?id={student.Id}", student);
                    task.Wait();
                    if (task.Result.IsSuccessStatusCode)
                    {
                        return RedirectToAction("Index");
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            StudentViewModel student = new StudentViewModel();
            using (HttpClient hc = new HttpClient())
            {
                hc.BaseAddress = new Uri("http://localhost/second/api/");
                var task = hc.GetAsync($"Students?id={id}");
                task.Wait();
                if (task.Result.IsSuccessStatusCode)
                {
                    var resultTask = task.Result.Content.ReadAsAsync<StudentViewModel>();
                    resultTask.Wait();
                    student = resultTask.Result;
                }
            }
            return View(student);
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection body)
        {
            try
            {
                using (HttpClient hc = new HttpClient())
                {
                    hc.BaseAddress = new Uri("http://localhost/second/api/");
                    var task = hc.DeleteAsync($"Students?id={id}");
                    task.Wait();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
            return RedirectToAction("Index");
        }
    }
}
