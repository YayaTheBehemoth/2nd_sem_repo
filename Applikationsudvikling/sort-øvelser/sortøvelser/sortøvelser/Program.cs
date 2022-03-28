using System;
using System.Collections;
namespace sortøvelser
{
    class Program
    {
        class CompareTest : IComparer
        {
            int IComparer.Compare(object x, object y)
            {
                return (new CaseInsensitiveComparer().Compare(y, x));
            }

         


        }
        static void Main(string[] args)
        {
            string[] test1 = { "how", "TF", "DOES", "this", "Thing", "even", "wOrK" };

            //create array called test and assign 20 random numbers to the index
            Random rnd = new Random();
            int[] test = new int[20];
            for(int i = 0; i < test.Length; i++)
            {
                test[i] = rnd.Next(50);
            }

            /* log statement to test if array was constructed properly (it was)
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
            */
            //the actual method signature 
         static int[] Bubblesort(int[] array)
            {
                //nested loop, the loop with the "i" iterator is the loop that actually does the "swapping"
                //the loop with the "j" iterator applies the operation that is executed in the "i-loop" an apropriate amount of times
                //NOTE: had we excluded the outer loop (j-loop), we would only have sorted once, making it so that ex. if the number at index 2
                //had been larger than the number at index 0, they wouldn't have been swapped
                for (int j = 0; j < array.Length - 1; j++)
                {
                    for (int i = 0; i < array.Length - 1; i++)
                    {
                        if (array[i] > array[i + 1])
                        {
                            int big = array[i];
                            int smol = array[i + 1];
                            array[i] = smol;
                            array[i + 1] = big;

                        }

                    }
                }
                //printing the result in the method, merely done to save time
                for(int i = 0; i< array.Length; i++)
                {
                    Console.WriteLine(array[i]);
                }
              
                return array;
            }

            Array.Sort(test1, test, new CompareTest());
            // Array.Sort(test,new CompareTest());
            for (int i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }

        // Array.Sort(test1,new CompareTest());
            for (int i = 0; i < test1.Length; i++)
            {
                Console.WriteLine(test1[i]);
            }

          
        }
    }
}
