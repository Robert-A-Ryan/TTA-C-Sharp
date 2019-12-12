using MillerInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MillerInsurance.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Quote()
        {
            ViewBag.Message = "Please fill out the form below to receive your insurance quote.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please reachout to us with any questions or comments.\n";

            return View();
        }

        [HttpPost]
        public ActionResult Result(string firstName, string lastName, string emailAddress, string dateOfBirth, int tickets, bool dui, bool fullCoverage, int year, string make, string model)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(year.ToString()) || string.IsNullOrEmpty(make) || string.IsNullOrEmpty(model))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (AutoInsurancedBEntities db = new AutoInsurancedBEntities())
                {
                    decimal rate = 50m;
                    int age = CalculateAge(dateOfBirth);

                    if (age < 25 && age > 18)
                    {
                        rate += 25m;
                    }
                    else if (age < 18)
                    {
                        rate += 100m;
                    }
                    else if (age > 100)
                    {
                        rate += 25m;
                    }

                    if (year < 2000)
                    {
                        rate += 25m;
                    }
                    else if (year > 2015)
                    {
                        rate += 25m;
                    }

                    if (make == "Porsche")
                    {
                        rate += 25m;
                        if (model == "911 Carrera")
                        {
                            rate += 25m;
                        }
                    }

                    if (tickets > 0)
                    {
                        rate += tickets * 10;
                    }

                    if (dui)
                    {
                        rate += rate * .25m;
                    }

                    if (fullCoverage)
                    {
                        rate = rate * 1.5m;
                    }

                    var customer = new Customer();
                    var automobile = new Automobile();
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.EmailAddress = emailAddress;
                    customer.DateOfBirth = Convert.ToDateTime(dateOfBirth);
                    customer.Tickets = tickets;
                    customer.DUI = dui;
                    customer.FullCoverage = fullCoverage;
                    customer.Rate = rate;
                    automobile.Year = year;
                    automobile.Make = make;
                    automobile.Model = model;

                    db.Customers.Add(customer);
                    db.Automobiles.Add(automobile);
                    db.SaveChanges();
                    
                    ViewBag.customer = customer;
                    ViewBag.automobile = automobile;

                    return View();
                }
            }

            int CalculateAge(string dob)
            {
                DateTime yob = Convert.ToDateTime(dob);
                int age;
                age = DateTime.Now.Year - yob.Year;
                if (DateTime.Now.DayOfYear < yob.DayOfYear)
                {
                    age -= 1;
                }
                return age;
            }
        }
    }
}
