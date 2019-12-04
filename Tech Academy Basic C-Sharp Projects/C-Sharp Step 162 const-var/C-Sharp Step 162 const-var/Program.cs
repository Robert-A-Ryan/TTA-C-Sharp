using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_162_const_var
{
    class Program
    {
        static void Main(string[] args)
        {
            const string homeTown = "Renton, WA";

            var dadHomeTown = "Ada, OK";

            Console.WriteLine("My Dad is from {0}, and I am from {1}.", dadHomeTown, homeTown);

            Console.ReadLine();
        }
    }
}
