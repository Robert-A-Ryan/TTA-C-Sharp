using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_129_Override_Oper
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() { firstName = "Sample", lastName = "Student", Id = 2 };
            Emp1.SayName();
            Emp1.Quit();
            Employee Emp2 = new Employee() { firstName = "Another", lastName = "Sample", Id = 3 };
            Emp2.SayName();
            Emp2.Quit();


            // step 129 employee id comparison
            if (Emp1.Id == Emp2.Id)
                Console.WriteLine("These entries are duplicates of the same person.");
            else
                Console.WriteLine("These entries are not duplicates.");



            Console.ReadLine();
        }
    }
}
