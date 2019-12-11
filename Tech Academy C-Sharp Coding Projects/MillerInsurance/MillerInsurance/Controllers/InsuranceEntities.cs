using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MillerInsurance.Controllers
{
    internal class InsuranceEntities
    {
        public object Customers { get; internal set; }
        public object Automobiles { get; internal set; }

        internal void SaveChanges()
        {
            throw new NotImplementedException();
        }
    }
}