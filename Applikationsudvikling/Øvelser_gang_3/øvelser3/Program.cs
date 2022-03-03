using System;

namespace øvelser3
{

    class Program
    {

        static void Main(string[] args)
        {   //opgave 3.1
            /*
            int arrayLength = Int32.Parse(Console.ReadLine());
            int[] userArr = new int [arrayLength];
            for (int i = 0; i < (arrayLength); i++)
            {


                int counter = Int32.Parse(Console.ReadLine());
                userArr[i] = counter;
            }
         for (int i = arrayLength-1; i >= 0; i--)
            {
                Console.Write(userArr[i]);
            }
            */
            // opgave 3.2
            /*
            string[] meatArr = { "lam", "kylling", "okse" };
            string[] breadArr = { "hvidt", "groft" };
            string[] toppingArr = { "chili", "hvidløg" };
            Random rand = new Random();
            int index = rand.Next(meatArr.Length);
            int index1 = rand.Next(breadArr.Length);
            int index2 = rand.Next(toppingArr.Length);
    Console.WriteLine($"Du skal have en rulle med {meatArr[index]}, dit brød skal være{breadArr[index1]}, du skal have {toppingArr[index2]} som topping");
            */
            //opgave 3.3
            /*
            int[] randNum = { 4, 5, 6, 23, 1000, 99, 100 };
            int CurrentHighest = 0;
            for (int i = 0; i < randNum.Length; i++)
            {
               if (randNum[i] > CurrentHighest)
                {
                    CurrentHighest = randNum[i];
                }
            }
            Console.WriteLine(CurrentHighest);
            */
            //opgave 3.4
            //a
            /*
            int[] randomArr = new int[50];
            Random rnd = new Random();
            
            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = rnd.Next(50);
            }
            */
            /*
            for (int i = 0; i < randomArr.Length; i++)
            {
                Console.WriteLine(randomArr[i] + " ");
            }
            //b
            for (int i = randomArr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(randomArr[i] + " ");
            }
     
            
            //c
            for (int i = 10; i < 31; i++)
            {
                
                Console.WriteLine(randomArr[i]);
            }
            */
            //d
            /*
            for (int i = 0; i < randomArr.Length; i++)
            {
                if (randomArr[i] > 10 && randomArr[i] < 20)
                {
                    Console.WriteLine(randomArr[i]);
                }
            }
            
            //e
            findAntalN(randomArr, 16);
            static Int32 findAntalN(Int32[] tabel, int tal)
            {
                int numberCounter = 0;
                for (int i = 0; i < tabel.Length; i++)
                {
                    if (tabel[i] == tal)
                    {
                        numberCounter = numberCounter + 1;

                    }
                    if (numberCounter == 0)
                    {
                        numberCounter = -1;
                    }
                }
                Console.WriteLine(numberCounter);
                return numberCounter;
            }

            //f
            findforste(randomArr, 4);
            static int findforste (int[] tabel, int tal)
            {
                int firstIndex = -1;
                for (int i = 0; i < tabel.Length; i++)
                {
                    if (tabel[i] == tal)
                    {
                        firstIndex = i;
                        break;
                    }
                }
                Console.WriteLine(firstIndex);
                return firstIndex;
            */
            //3.05
            //a
            
            double[] temp = new double[10];
            for (int i = 0; i < 10; i++)
            {
                temp[i] = randomInRange(15, 35);
            }
            int hotCount = 0;
            foreach (int n in temp)
            {
                
                if (n > 25)
                {
                  hotCount = hotCount + 1;
                }
            }

            Console.WriteLine(hotCount);

            static int GreaterCount (double[]array, double min)
            {
                int hotCount = 0;
                foreach (int n in array)
                {

                    if (n >= min)
                    {
                        hotCount = hotCount + 1;
                    }
                }
                Console.WriteLine($"there are {hotCount} occurences of {min}");
                return hotCount;
            }
            GreaterCount(temp, 16);
            
            //b
            
            static int randomInRange (int min, int max)
            {
                Random rnd = new Random();
                int ret = rnd.Next(min, max);
                Console.WriteLine(ret);
                return ret; 
            }
            
            //randomInRange(15, 35);
            
            // 3.06 my teacher cant formulate an assignment for shit lmfao (new assignment: make a method that takes three arguments, current balance, amount of years and interest)
            //return the new amount
            /*
            static double getNewBalance (double balance, double interest, double years)
            {
                double oldBalance = balance;
                for (int i = 0; i < years; i++)
                {
                   oldBalance = oldBalance * ((0.01 * interest)+1);
                }
                Console.WriteLine($"your new balance under the current conditions would be {oldBalance}");
                return oldBalance;
                
            }
            getNewBalance(10000.0,4.0,5.0);
          */
        }
        
    }

}


