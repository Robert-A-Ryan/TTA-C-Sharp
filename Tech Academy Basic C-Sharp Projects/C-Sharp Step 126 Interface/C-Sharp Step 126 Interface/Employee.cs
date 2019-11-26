using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_126_Interface
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("{0} {1} ended thier employment.", firstName, lastName);
        }
    }
}
