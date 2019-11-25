using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_117_Class_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            DivBy2 db2 = new DivBy2();  //Steps 1-3
            Console.WriteLine("Please enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());

            db2.DivMath(num1);


            // Step 4
            MultiP(out int j, out int k);

            Console.WriteLine("The value of j is: {0}", j);
            Console.WriteLine("The value of k is: {0}", k);

            Console.ReadLine();

            //Step 5 Overload
            MultiP(out string p, out string q);

            Console.WriteLine(p);
            Console.WriteLine(q);

            Console.ReadLine();

            // Step 6
            string schoolName = Schoolnfo.GetSchoolName();
            string schoolCity = Schoolnfo.GetSchoolCity();
            Console.WriteLine(schoolName + " " + schoolCity);

            Console.ReadLine();

        }
        public static void MultiP(out int a, out int b)
        {
            a = 24;
            a = a * 2;
            b = 60;
            b = b * b;

        }

        public static void MultiP(out string c, out string d)
        {
            c = "Hello";
            d = "Everybody";
            
        }
    }
}
