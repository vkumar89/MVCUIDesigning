using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class EmpController:Controller
    {
        [HttpGet]
        public ViewResult AddEmp()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddEmp(Employee Emp)
        {
            return View("Display2",Emp);
        }
    }
}