using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_114_More_Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 using an int variable
            SomeMath SomeMath = new SomeMath();

            int num1 = 5;

            Console.WriteLine(SomeMath.MathSome(num1));
            

            //#2 using a decimal variable
            SomeMath MathSome = new SomeMath();

            decimal num2 = 2.26m;

            Console.WriteLine(MathSome.MathSome(num2));


            //#3 using a string converted to int
            SomeMath sm = new SomeMath();

            string num3 = "4";

            try
            {
                Console.WriteLine(sm.MathSome(num3));
            }
            catch (UriFormatException ex)
            {
                Console.WriteLine("Please provide a number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }



            Console.ReadLine();
        }


    }
}
