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
            Employee Emp1 = new Employee() { firstName = "Sample", lastName = "Student", Id = 2 };
            Emp1.SayName();
            Emp1.Quit();
            Employee Emp2 = new Employee() { firstName = "Another", lastName = "Sample", Id = 3 };
            Emp2.SayName();
            Emp2.Quit();

            if (Emp1.Id == Emp2.Id)
                Console.WriteLine("These entries are duplicates of the same person.");
            else
                Console.WriteLine("These entries are not duplicates.");

            //################################ is this what #3 is referring to?  Use polymorphism to create an object of type IQuittable and call the Quite() method
            
            Manager Man1 = new Manager() { firstName = "Big", lastName = "Wig", Id = 1, isManager = true };
            Man1.SayName();
            Man1.Quit();

            Console.ReadLine();
        }
        
    }
}
