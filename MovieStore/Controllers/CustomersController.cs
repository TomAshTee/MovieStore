using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieStore.Models;
using MovieStore.ViewModels;

namespace MovieStore.Controllers
{
    public class CustomersController : Controller
    {
        public List<Customer> customersList = new List<Customer>
        {
            new Customer {Name = "Thomas", Id = "1"},
            new Customer {Name = "Alex", Id = "2"},
            new Customer {Name = "Jane", Id = "3"},
            new Customer {Name = "John", Id = "4"}
        };

        // GET: Customers
        public ActionResult Index()
        {
            var customersViewModel = new CustomerViewModel();
            customersViewModel.Customers = customersList;

            return View(customersViewModel);
        }

        public ActionResult Details(string id)
        {
            var customer = customersList.Find(x => x.Id == id);
            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }
    }
}