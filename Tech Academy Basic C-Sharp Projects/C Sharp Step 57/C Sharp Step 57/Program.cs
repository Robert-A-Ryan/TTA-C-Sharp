using System;

namespace C_Sharp_Step_57
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report\n");
            Console.WriteLine("What course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number?");
            string page = Console.ReadLine();
            int pages = Convert.ToInt32(page);
            Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\".");
            string help = Console.ReadLine();
            bool helps = Convert.ToBoolean(help);
            Console.WriteLine("Are there any positive experiences you'd like to share? Please give specifics.");
            string positive = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string hoursStudy = Console.ReadLine();
            sbyte Study = Convert.ToSByte(hoursStudy);
            Console.WriteLine("\nThank you for your answers. An instructor will respond to this shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}
