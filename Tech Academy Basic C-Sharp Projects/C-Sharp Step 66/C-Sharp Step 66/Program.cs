using System;

namespace C_Sharp_Step_66
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy C# Step 66");
            Console.WriteLine("");
            Console.WriteLine("Please enter a number.");
            string userNum1 = Console.ReadLine();
            uint compNum1 = Convert.ToUInt32(userNum1) * 50;
            Console.WriteLine("Your number multiplied by 50 is: " + compNum1);
            Console.WriteLine("");
            Console.WriteLine("Please enter another number.");
            string userNum2 = Console.ReadLine();
            int compNum2 = Convert.ToInt32(userNum2) + 25;
            Console.WriteLine("Your number increased by 25 is: " + compNum2);
            Console.WriteLine("");
            Console.WriteLine("Please enter another number.");
            string userNum3 = Console.ReadLine();
            double compNum3 = Convert.ToDouble(userNum3) / 12.5;
            Console.WriteLine("Your number divided by 12.5 is: " + compNum3);
            Console.WriteLine("");
            Console.WriteLine("Please enter yet, another number.");
            string userNum4 = Console.ReadLine();
            bool compNum4 = Convert.ToInt32(userNum4) >= 50;
            Console.WriteLine("Is your number greater than 50?: " + compNum4);
            Console.WriteLine("");
            Console.WriteLine("Please enter another number.");
            string userNum5 = Console.ReadLine();
            int compNum5 = Convert.ToInt32(userNum5) % 7;
            Console.WriteLine("The remainder of " + userNum5 + " divided by 7 is: " + compNum5);            
            Console.ReadLine();
        }
    }
}
