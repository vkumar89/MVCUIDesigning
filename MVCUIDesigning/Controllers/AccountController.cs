using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace MVCUIDesigning.Controllers
{
    public class AccountController : Controller
    {
        public ViewResult Login()
        {
            return View();
        }
        public ViewResult Validate()
        {
            string Name = Request["txtName"];
            string Password = Request["Password"];
            if(Name == "Vipin" || Password == "vipin@123")
            {
                return View("Success");
            }
            else
            {
                return View("Failure");
            }  
        }
    }
}