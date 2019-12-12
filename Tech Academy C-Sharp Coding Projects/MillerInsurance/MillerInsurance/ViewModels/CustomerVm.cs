using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MillerInsurance.ViewModels
{
    public class CustomerVm
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public decimal Rate { get; set; }
    }
}