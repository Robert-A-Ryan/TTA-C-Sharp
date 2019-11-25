using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_124_Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() { firstName = "Sample", lastName = "Student" };
            Emp1.SayName();

            Console.ReadLine();
        }
    }
}
