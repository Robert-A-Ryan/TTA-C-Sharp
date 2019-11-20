using System;
using System.Collections.Generic;
using System.Linq;

namespace C_Sharp_Step_103_For_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //##########################################below is 1
            //string[] words = new string[5];
            //Console.WriteLine("Please type something.");
            //string uWords = Console.ReadLine().ToLower();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i] = uWords;
            //}

            //for (int p = 0; p < words.Length; p++)
            //{
            //    Console.WriteLine(words[p]);
            //}

            //###########################################below is 2
            //for (int i = 0; i < 2; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //###########################################below is 3
            //for (int i = 0; i < 2; i--)
            //{
            //    Console.WriteLine(i);
            //    if (i == -100)
            //    {
            //        break;
            //    }
            //}

            //############################################below is 4
            //for (int i = 0; i < 24; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //#############################################below is 5
            //for (int i = 50; i <= 25; i--)
            //{
            //    Console.WriteLine(i);
            //}


            //################################################below is 6-8
            //List<string> someWords = new List<string>() { "abc", "def", "hig", "jkl", "mno", "pqr", "stu", "vwx", "yz" };
            //Console.WriteLine("Please choose a text search term for the list.");
            //string searchTerm = Console.ReadLine().ToLower();
            //int count = 0;

            //foreach (string word in someWords)
            //{
            //    if (word.Contains(searchTerm))
            //    {
            //        count++;
            //        Console.WriteLine(someWords.IndexOf(word));
            //        break;
            //    }
            //}
            //if (count == 0)
            //{
            //    Console.WriteLine("Your search term is not in this list.");
            //}





            //####################################################below is 9-10
            //List<string> lOfWords = new List<string>() { "bob", "connor", "banana", "boat", "enumerate", "boat", "apple" };
            //Console.WriteLine("Please type in a search term.");
            //string lSearch = Console.ReadLine().ToLower();
            //int count = 0;
            //int idx = -1;

            //foreach (string word in lOfWords)
            //{
            //    idx++;
            //    if (word.Contains(lSearch))
            //    {
            //        count++;
            //        Console.WriteLine("Your search term was found at index location: " + idx);
            //        //count++;
            //        //Console.WriteLine("Your search term was found at index location: " + (lOfWords.IndexOf(word)));
            //    }
            //}

            //if (count == 0)
            //{
            //    Console.WriteLine("Your search term is not found in this list.");
            //}

            //##############################################below is 11
            List<string> idList = new List<string>() { "bob", "connor", "banana", "boat", "enumerate", "boat", "apple" };

            var duplicates = from d in idList
                             group d by d into c
                             let count = c.Count()
                             orderby count descending
                             select new { Value = c.Key, Count = count };

            foreach (var v in duplicates)
            {
                string strValue = v.Value;
                int Count = v.Count;

                Console.WriteLine("Word {0} has {1} entries in this list." ,strValue, Count);
            }


            

            Console.ReadLine();

        }
    }
}
