using LukasVanagas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LukasVanagas.Controllers
{
    public class HomeController : Controller
    {
        private static List<Employee> employees = new List<Employee>
        {
            new Employee
            {
                id = "10",
                firstName = "Demetris",
                lastName = "Kyriacou"
            },
            new Employee
            {
                id = "20",
                firstName = "Kostas",
                lastName = "Aristotelous"
            }
        };


        public ActionResult Index()
        {
            ViewBag.Title = "Employees List";
            ViewBag.Action = "Index";
            return View(employees);
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Title = "Add New Employee";
            ViewBag.Action = "Create";
            return View();
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employees.Add(employee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Update(string id)
        {
            ViewBag.Title = "Update Employee";
            return View(employees.First(e => e.id == id));
        }

        [HttpPost]
        public ActionResult Update(Employee employee)
        {
            employees.RemoveAll(e => e.id == employee.id);
            employees.Add(employee);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Destroy()
        {
            ViewBag.Title = "Delete Employee";
            ViewBag.Action = "Destroy";
            return View();
        }

        [HttpPost]
        public ActionResult Destroy(string id)
        {
            employees.RemoveAll(e => e.id == id);
            return RedirectToAction("Index");
        }
    }
}