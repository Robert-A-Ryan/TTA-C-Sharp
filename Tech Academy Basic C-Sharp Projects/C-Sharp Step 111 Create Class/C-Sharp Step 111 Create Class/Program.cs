using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_111_Create_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            AddSubtractMultiply myMath = new AddSubtractMultiply();
            
            Console.WriteLine("Please enter a whole number.");            
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("150 added to your number = " + myMath.Add(num1));
            Console.WriteLine("");
            Console.WriteLine("24 subtracted from your number = " + myMath.Subtract(num1));
            Console.WriteLine("");
            Console.WriteLine("Your number multiplied by 55 = " + myMath.Multiply(num1));

            Console.ReadLine();
            

            
            
            
        }
    }
}
