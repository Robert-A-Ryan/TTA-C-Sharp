using System;

namespace C_Sharp_Step_67_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate:");
            string p1Rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string p1Time = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate:");
            string p2Rate = Console.ReadLine();
            Console.WriteLine("Hours worked per week:");
            string p2Time = Console.ReadLine();
            Console.WriteLine("");
            decimal p1Pay = Convert.ToDecimal(p1Rate) * Convert.ToDecimal(p1Time);
            Console.WriteLine("Weekly Salary of Person 1:");
            Console.WriteLine(p1Pay);
            Console.WriteLine("");
            decimal p2Pay = Convert.ToDecimal(p2Rate) * Convert.ToDecimal(p2Time);
            Console.WriteLine("Weekly Salary of Person 2:");
            Console.WriteLine(p2Pay);
            Console.WriteLine("");
            bool moreMoney = p1Pay > p2Pay;
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            Console.WriteLine(moreMoney);
            Console.ReadLine();
        }
    }
}
