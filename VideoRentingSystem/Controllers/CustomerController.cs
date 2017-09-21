using System;
using System.Collections.Generic;
using System.Web.Mvc;
using VideoRentingSystem.Models;

namespace VideoRentingSystem.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var customer = GetCustomers();
            return View(customer);
        }

        private List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer { Id = 1, Name = "John Smith"},
                new Customer {Id = 2, Name = "Mary Williams"}
            };
        }

        public ActionResult Details(int id)
        {
            throw new NotImplementedException();
        }
    }
}