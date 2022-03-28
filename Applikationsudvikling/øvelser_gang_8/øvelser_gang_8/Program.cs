using System;
using System.Collections.Generic;

namespace øvelser_gang_8
{
    class Program
    {
        static void Main(string[] args)
        {   /*
            List<int> test = new List<int>();

            static void feedList(List<int> l) {
                Console.WriteLine("how many numbers should we add to the list?");
                int answer = int.Parse(Console.ReadLine());
                for (int i = 0; i <= answer; i++)
                {
                    Random rnd = new Random();
                    l.Add(rnd.Next(1, 1000));
                }
            }
            static int findHighestValue(List<int> l)
            {
                int[] lArray   = l.ToArray();
                int highestNum = 0;
                for(int i = 0; i < lArray.Length; i++)
                {
                    if (lArray[i] > highestNum)
                    {
                        highestNum = lArray[i];
                    }
                }
                Console.WriteLine(highestNum);
                return highestNum;

            }
            static bool findValue(int i, List<int>l)
            {
                Console.WriteLine(l.Contains(i));
               return l.Contains(i);
            }
            feedList(test);
            findHighestValue(test);
            findValue(534, test);
            */
          
          
            int[,] array2Da = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            Console.WriteLine((array2Da[2, 3]));

        }
    }
}
