using MVCUIDesigning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCUIDesigning.Controllers
{
    public class CustomerController:Controller
    {
        public ViewResult DisplayCustomers()
        {
            Customer c1=new Customer { CID=1001,Name="AAA",Account="Saving",Balance=5000,City="Delhi",Status=true,Photo="~/images/image1.jpg"};
            Customer c7 = new Customer
            {
                CID = 1001,
                Name = "Peter",
                Account = "Savings",
                Balance = 50000.00,
                City = "Delhi",
                Status = true,
                Photo = "~\\Images\\Image7.jpg"
            };
            Customer c2 = new Customer
            {
                CID = 1002,
                Name = "Kevin",
                Account = "Current",
                Balance = 50000.00,
                City = "Kolkata",
                Status = true,
                Photo = "~\\Images\\Image7.jpg"
            };
            Customer c3 = new Customer
            {
                CID = 1003,
                Name = "Sandra",
                Account = "Demat",
                Balance = 50000.00,
                City = "Mumabi",
                Status = true,
                Photo = "~\\Images\\Image7.jpg"
            };
            Customer c4 = new Customer
            {
                CID = 1004,
                Name = "Williams",
                Account = "Savings",
                Balance = 50000.00,
                City = "Chennai",
                Status = true,
                Photo = "~\\Images\\Image7.jpg"
            };
            Customer c5 = new Customer
            {
                CID = 1005,
                Name = "John",
                Account = "Demat",
                Balance = 50000.00,
                City = "Bengaluru",
                Status = true,
                Photo = "~\\Images\\Image7.jpg"
            };
            Customer c6 = new Customer
            {
                CID = 1006,
                Name = "Bill",
                Account = "Current",
                Balance = 50000.00,
                City = "Hyderabad",
                Status = true,
                Photo = "~\\Images\\Image7.jpg"
            };
            List<Customer> customers = new List<Customer> { c1, c2, c3, c4, c6, c7 };
            return View(customers);

        }
    }
}