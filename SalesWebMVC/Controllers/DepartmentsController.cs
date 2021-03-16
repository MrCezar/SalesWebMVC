using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            var departmentsList = new List<Department>();
            departmentsList.Add(new Department{Id = 1, Name = "Electronics"});
            departmentsList.Add(new Department{Id = 2, Name = "Fashion"});

            return View(departmentsList);
        }
    }
}
