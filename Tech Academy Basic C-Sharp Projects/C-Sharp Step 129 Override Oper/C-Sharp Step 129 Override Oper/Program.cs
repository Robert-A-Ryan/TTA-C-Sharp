﻿using System;
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
            Employee<string> Emp1 = new Employee<string>() { FirstName = "Sample", LastName = "Student", Id = 2 };
            Emp1.Things = new List<string>() { "something", "anotherthing", "evenmorethings", "somethingdifferent" };
            Emp1.SayName();
            Emp1.Quit();

            Console.WriteLine("\nEmployee {0}'s list.", Emp1.Id);
            foreach (string thing in Emp1.Things)
            {
                Console.WriteLine(thing);
            }

            Employee<int> Emp2 = new Employee<int> { FirstName = "Another", LastName = "Sample", Id = 3};
            Emp2.Things = new List<int>() { 1, 4, 6, 22, 365 };
            Emp2.SayName();
            Emp2.Quit();

            Console.WriteLine("Employee {0}'s list.", Emp2.Id);
            foreach (int thing in Emp2.Things)
            {
                Console.WriteLine(thing);
            }


            // step 129 employee id comparison
            if (Emp1.Id == Emp2.Id)
                Console.WriteLine("\nThese entries are duplicates of the same person.");
            else
                Console.WriteLine("\nThese entries are not duplicates.");


            // Is this the polymorphism we are looking for?  When I try to use SayName() it errors stating that IQuitable doesn't have the function
            IQuitable Emp3 = new Employee<int> { FirstName = "Third", LastName = "Sample", Id = 4};

            Console.ReadLine();
        }
    }
}
