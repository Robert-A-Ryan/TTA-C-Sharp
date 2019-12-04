using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Step_165_Exception
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");

            try
            {
                int uAge = Convert.ToInt32(Console.ReadLine());
                if (uAge < 1)
                {
                    throw new ImpossibleAgeException();
                }
                var uYear = DateTime.Now.AddYears(-uAge);
                Console.WriteLine("You were born in {0}.", uYear.Year);
                Console.ReadLine();
            }
            catch (ImpossibleAgeException)
            {
                Console.WriteLine("LOL, you can't be 0 or less years old.");
                Console.ReadLine();
                return;
            }
            catch (Exception)
            {
                Console.WriteLine("An error occurred, please contact your Systems Administrator.");
                Console.ReadLine();
                return; 
            }

        }
    }
}
