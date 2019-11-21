using System;

namespace C_Sharp_Step_92_Shipping_Estimate
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instrutions below.\n");
            Console.WriteLine("What is the weight of the package?");
            int pWeight = Convert.ToInt32(Console.ReadLine());

            if (pWeight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("\nWhat is the package width?");
                int pWidth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package height?");
                int pHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the package lenght?");
                int pLenght = Convert.ToInt32(Console.ReadLine());
                int pSize = pWidth + pHeight + pLenght;

                if (pSize > 50)
                {
                    Console.WriteLine("Package is too large to be shipped via Package Express. Have a good day.");
                }
                else
                {
                    decimal price = (pSize * pWeight) / 100;
                    Console.WriteLine("\nYour shipping rate is $" + price + ". Thank you.");
                }

            }
            


            Console.ReadLine();
        }
    }
}
