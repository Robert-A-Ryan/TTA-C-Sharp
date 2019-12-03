using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace C_Sharp_Step_154_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            //ask the user for a number
            Console.WriteLine("Please enter a number");
            int number;
            bool corInt = int.TryParse(Console.ReadLine(), out number) && number > 0;

            while (!corInt)
            {
                Console.WriteLine("You didn't enter a number, please try again.");
                corInt = int.TryParse(Console.ReadLine(), out number) && number > 0;
            }

            //log the number to a file
            using (StreamWriter file = new StreamWriter(@"C:\Users\coach\Documents\The-Tech-Academy-Projects\C-Sharp\Tech Academy Basic C-Sharp Projects\S154Log.txt", true))
            {
                file.WriteLine(number);
            }

            //retrieve the text from the log file and print to the console
            string rNumber = File.ReadAllText(@"C:\Users\coach\Documents\The-Tech-Academy-Projects\C-Sharp\Tech Academy Basic C-Sharp Projects\S154Log.txt");
            Console.WriteLine("\n\n\n" + rNumber);


            Console.WriteLine("Hit any key to continue.");
            Console.ReadLine();
        }
    }
}
