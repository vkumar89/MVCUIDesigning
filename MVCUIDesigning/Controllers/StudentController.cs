using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCUIDesigning.Models;

namespace MVCUIDesigning.Controllers
{
    public class StudentController : Controller
    {
        [HttpGet]
        public ViewResult AddStudent()
        {
            return View();
        }
        [HttpPost]

        public ViewResult AddStudent(Student stu)
        {
            return View("DisplayStudent", stu);
        }

        [HttpGet]
        public ViewResult AddStudentST()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddStudentST(Student stu)
        {
            return View("DisplayStudentST",stu);

        }
        public PartialViewResult Header()
        {
            return PartialView("_Header");
        }

    }
}