using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_126_Interface
{
    public class Employee : Person, IQuittable
    {
        public int Id { get; set; }
        public void Quit()
        {
            Console.WriteLine("{0} {1} ended thier employment.", firstName, lastName);
        }
        
        // employee id comparison by overloading the == operator
        public static bool operator ==(Employee id1, Employee id2)
        {
            if (id1 == id2)
                return true;
            else
                return false;
        }

    }
}
