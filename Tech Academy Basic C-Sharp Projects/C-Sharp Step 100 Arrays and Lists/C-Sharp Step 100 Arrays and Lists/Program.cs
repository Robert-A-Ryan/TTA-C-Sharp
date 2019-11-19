using System;
using System.Collections.Generic;


namespace C_Sharp_Step_100_Arrays_and_Lists
{
    class Program
    {
        static void Main()
        {
            //string[] sArray = { "bob", "john", "bailey", "connor", "christen" };
            //Console.WriteLine("Choose a number from 0 to 4.");
            //Console.WriteLine(sArray[Convert.ToInt32(Console.ReadLine())]);

            //int[] iArray = { 1, 2, 7, 24, 20000, 3 };
            //Console.WriteLine("Choose a number from 0 to 5.");
            //Console.WriteLine(iArray[Convert.ToInt32(Console.ReadLine())]);

            string[] sArray = { "bob", "john", "bailey", "connor", "christen" };
            Console.WriteLine("Choose a number to find a name.");
            int sAIndex = Convert.ToInt32(Console.ReadLine());
            bool trueIndex = sAIndex < sArray.Length;

            do
            {
                switch (sAIndex)
                {
                    case 0:
                        Console.WriteLine(sArray[sAIndex]);
                        trueIndex = true;
                        break;
                    case 1:
                        Console.WriteLine(sArray[sAIndex]);
                        trueIndex = true;
                        break;
                    case 2:
                        Console.WriteLine(sArray[sAIndex]);
                        trueIndex = true;
                        break;
                    case 3:
                        Console.WriteLine(sArray[sAIndex]);
                        trueIndex = true;
                        break;
                    case 4:
                        Console.WriteLine(sArray[sAIndex]);
                        trueIndex = true;
                        break;
                    default:
                        Console.WriteLine("Your number is too large, please choose a smaller number.");
                        sAIndex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!trueIndex);
          

            int[] iArray = { 1, 2, 7, 24, 20000, 3 };
            Console.WriteLine("Choose a number.");
            int iAIndex = Convert.ToInt32(Console.ReadLine());
            bool trueIIndex = iAIndex < iArray.Length;

            do
            {
                switch (iAIndex)
                {
                    case 0:
                        Console.WriteLine(iArray[iAIndex]);
                        trueIIndex = true;
                        break;
                    case 1:
                        Console.WriteLine(iArray[iAIndex]);
                        trueIIndex = true;
                        break;
                    case 2:
                        Console.WriteLine(iArray[iAIndex]);
                        trueIIndex = true;
                        break;
                    case 3:
                        Console.WriteLine(iArray[iAIndex]);
                        trueIIndex = true;
                        break;
                    case 4:
                        Console.WriteLine(iArray[iAIndex]);
                        trueIIndex = true;
                        break;
                    case 5:
                        Console.WriteLine(iArray[iAIndex]);
                        trueIIndex = true;
                        break;
                    default:
                        Console.WriteLine("Your number is too large, please choose a smaller number.");
                        iAIndex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!trueIIndex);

            List<string> sList = new List<string>() { "bob", "sarah", "boat", "chimpanzee"};
            Console.WriteLine("Choose a number.");
            int lIndex = Convert.ToInt32(Console.ReadLine());
            bool trueList = lIndex < sList.Count;


            do
            {
                switch (lIndex)
                {
                    case 0:
                        Console.WriteLine(sList[lIndex]);
                        trueList = true;
                        break;
                    case 1:
                        Console.WriteLine(sList[lIndex]);
                        trueList = true;
                        break;
                    case 2:
                        Console.WriteLine(sList[lIndex]);
                        trueList = true;
                        break;
                    case 3:
                        Console.WriteLine(sList[lIndex]);
                        trueList = true;
                        break;
                    default:
                        Console.WriteLine("Your number is too large, please choose a smaller number.");
                        lIndex = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!trueList);

            Console.ReadLine();

        }
    }
}
