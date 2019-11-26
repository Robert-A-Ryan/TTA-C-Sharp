using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_126_Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee() { firstName = "Sample", lastName = "Student" };
            Emp1.SayName();
            Emp1.Quit();

            //################################ is this what #3 is referring to?  Use polymorphism to create an object of type IQuittable and call the Quite() method
            
            Manager Man1 = new Manager() { firstName = "Big", lastName = "Wig" };
            Man1.SayName();
            Man1.Quit();

            Console.ReadLine();
        }
        
    }
}
