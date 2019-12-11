using MillerInsurance.Models;
using MillerInsurance.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MillerInsurance.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (AutoInsurancedBEntities db = new AutoInsurancedBEntities())
            {
                var customers = db.Customers;
                var customerVms = new List<CustomerVm>();
                foreach (var customer in customers)
                {
                    var customerVm = new CustomerVm
                    {
                        FirstName = customer.FirstName,
                        LastName = customer.LastName,
                        EmailAddress = customer.EmailAddress
                    };
                    customerVms.Add(customerVm);
                }
                return View(customerVms);
            }

        }
    }
}