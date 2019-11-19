using System;

namespace C_Sharp_Step_75___Car_Insurance
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please answer these questions so we can determine if you are elligable for our car insurance.");
            Console.WriteLine("");
            Console.WriteLine("What is your age?");
            string age = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Have you ever had a DUI? Please answer \"true\" or \"false\"");
            string DUI = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("How many traffic infractions have you had?");
            string tickets = Console.ReadLine();

            int dAge = Convert.ToInt32(age);
            bool dDUI = Convert.ToBoolean(DUI);
            int dTickets = Convert.ToInt32(tickets);

            bool qualified = (dAge > 15 && dDUI != true && dTickets <= 3);

            Console.WriteLine("Are you qualified for our product?");
            Console.WriteLine(qualified);
                        
            Console.ReadLine();
        }
    }
}
