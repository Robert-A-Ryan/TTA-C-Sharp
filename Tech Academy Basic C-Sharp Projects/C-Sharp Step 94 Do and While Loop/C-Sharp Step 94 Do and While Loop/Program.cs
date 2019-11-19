using System;

namespace C_Sharp_Step_94_Do_and_While_Loop
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is my favorite color?");
            string guess = Console.ReadLine();
            bool myColor = guess == "red";

            //while (!myColor)
            //{
            //    switch (guess)
            //    {
            //        case "green":
            //            Console.WriteLine("You guessed green. Try again.");
            //            Console.WriteLine("Guess my favorite color.");
            //            guess = Console.ReadLine();
            //            break;
            //        case "blue":
            //            Console.WriteLine("You guessed blue. Try again.");
            //            Console.WriteLine("Guess my favorite color.");
            //            guess = Console.ReadLine();
            //            break;
            //        case "yellow":
            //            Console.WriteLine("You guessed yellow. Try again.");
            //            Console.WriteLine("Guess my favorite color.");
            //            guess = Console.ReadLine();
            //            break;
            //        case "red":
            //            Console.WriteLine("You guessed red, you are correct!");
            //            myColor = true;
            //            break;
            //        case "orange":
            //            Console.WriteLine("You guessed orange. Try again.");
            //            Console.WriteLine("Guess my favorite color.");
            //            guess = Console.ReadLine();
            //            break;
            //        case "purple":
            //            Console.WriteLine("You guessed purple. Try again.");
            //            Console.WriteLine("Guess my favorite color.");
            //            guess = Console.ReadLine();
            //            break;
            //        default:
            //            Console.WriteLine("You are incorrect.");
            //            Console.WriteLine("Guess my favorite color.");
            //            guess = Console.ReadLine();
            //            break;
            //    }
            //}

            do
            {
                switch (guess)
                {
                    case "green":
                        Console.WriteLine("You guessed green. Try again.");
                        Console.WriteLine("Guess my favorite color.");
                        guess = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("You guessed blue. Try again.");
                        Console.WriteLine("Guess my favorite color.");
                        guess = Console.ReadLine();
                        break;
                    case "yellow":
                        Console.WriteLine("You guessed yellow. Try again.");
                        Console.WriteLine("Guess my favorite color.");
                        guess = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("You guessed red, you are correct!");
                        myColor = true;
                        break;
                    case "orange":
                        Console.WriteLine("You guessed orange. Try again.");
                        Console.WriteLine("Guess my favorite color.");
                        guess = Console.ReadLine();
                        break;
                    case "purple":
                        Console.WriteLine("You guessed purple. Try again.");
                        Console.WriteLine("Guess my favorite color.");
                        guess = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You are incorrect.");
                        Console.WriteLine("Guess my favorite color.");
                        guess = Console.ReadLine();
                        break;
                }
            }
            while (!myColor);

            Console.ReadLine();
        }
    }
}
