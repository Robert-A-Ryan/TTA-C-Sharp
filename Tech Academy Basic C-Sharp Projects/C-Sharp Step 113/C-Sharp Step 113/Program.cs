using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_113
{
    class Program
    {
        static void Main(string[] args)
        {
            // declare to integer variables and assign values
            int num1 = 4;
            int num2 = 6;

            //instantiate an object of our class, and call the class function with two numbers
            Step113 step = new Step113();
            step.FunM(4, 6);

            //call the class function passing the named parameters
            step.FunM(num1, num2);

            Console.ReadLine();
        }

    }
}
