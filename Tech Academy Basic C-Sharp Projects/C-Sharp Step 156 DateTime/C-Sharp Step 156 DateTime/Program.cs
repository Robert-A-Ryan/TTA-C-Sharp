using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_156_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);

            Console.WriteLine("\n\nPlease enter a number.");

            int userNumber = Convert.ToInt32(Console.ReadLine());

            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now.AddHours(userNumber);
            Console.WriteLine("\n\nIt will be {0} in {1} hours.", dateTime, userNumber);

            Console.ReadLine();
        }
    }
}
