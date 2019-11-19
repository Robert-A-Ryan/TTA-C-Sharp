using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_97_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your first name?");
            //string fName = Console.ReadLine();
            //Console.WriteLine("What is your middle initial?");
            //string midInit = Console.ReadLine();
            //Console.WriteLine("What is your last name?");
            //string lName = Console.ReadLine();
            //string fullName = (fName + " " + midInit + " " + lName);
            //Console.WriteLine("Your name is: " + fullName);
            //string allCaps = fullName.ToUpper();
            //Console.WriteLine(allCaps);

            StringBuilder yourName = new StringBuilder();

            Console.WriteLine("What is your first name?");
            yourName.Append("Your first name is: " + Console.ReadLine());
            yourName.Append("\n");
            Console.WriteLine("What is your middle initial?");
            yourName.Append("Your middle initial is: " + Console.ReadLine());
            yourName.Append("\n");
            Console.WriteLine("What is your last name?");
            yourName.Append("Your last name is: " + Console.ReadLine());
            Console.WriteLine(yourName);



            Console.ReadLine();
        }
    }
}
