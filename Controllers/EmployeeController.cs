using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            IList<Employee> employees = new List<Employee>();

            employees.Add(new Employee() { ID = 101, FirstName = "Mohamed", LastName = "Safeudeen" });
            employees.Add(new Employee() { ID = 102, FirstName = "kader", LastName = "Thousif" });
            employees.Add(new Employee() { ID = 103, FirstName = "Md", LastName = "Saif" });

            ViewData["employees"] = employees;
            return View();


        }
    }
}
