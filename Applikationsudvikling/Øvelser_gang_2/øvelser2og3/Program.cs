
using System;
class main
{
    public static void Main()
    {
        //Opgave 2.01
        /*
        Console.WriteLine("Greetings subject, please identify yourself");
        string name  = Console.ReadLine();
        Console.WriteLine("Please inform the gorvernment of how much you've slept this night");
        int sleep = Convert.ToInt32(Console.ReadLine());
        if (sleep < 8)
        {
            Console.WriteLine($"It is imperative that subjects get sufficient amounts of sleep, otherwise productivity will halter! Transgression of behavioural guidelines noted for {name}");
        } else
        {
            Console.WriteLine($"It is good that you are sufficiently well rested,{name}");
        }
        */
        //Opgave 2.02
        /*
        Console.WriteLine("How many Propaganda-papers are you delivering?");
        int paperCount = Convert.ToInt32(Console.ReadLine());
        if (paperCount % 50 == 0)
        {
            int bundleCount = paperCount / 50;
            Console.WriteLine($"You are delivering {bundleCount} bundles of propaganda today");
        }
        else
        {
            int bundleCount = paperCount / 50;
            int looseCount = paperCount % 50;
            Console.WriteLine($"you are delivering {bundleCount} bundles of propaganda, as well as {looseCount} loose papers of propaganda today!");
        }
         */
        //Opgave 2.03
        /*
        Console.WriteLine("please enter the name of the current month!");
        string currentMonth = (Console.ReadLine());
        int dayCount = 0;
        switch(currentMonth)
        {
            case "January" :
                dayCount = 30;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "February":
                dayCount = 29;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "March":
                dayCount = 31;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "April":
                dayCount = 30;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "May":
                dayCount = 31;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "June":
                dayCount = 30;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "July":
                dayCount = 31;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "August":
                dayCount = 30;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "September":
                dayCount = 31;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "October":
                dayCount = 30;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "November":
                dayCount = 31;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            case "December":
                dayCount = 31;
                Console.WriteLine($"{currentMonth} has {dayCount} days");
                break;
            default:
                Console.WriteLine("Could not identify that month, please check that your spelling is correct");
                    dayCount = 0;
                    break;


        }
        */
        //Opgave 2.04
        /*
        {
            //actual roomtemp iq assigment lmfao
        }
        */
        //Opgave 2.05a
        /*
        for (int i =0; i<= 100; i++)
        {
            if (((i % 5) == 0) && ((i % 3) == 0))
            {
                Console.WriteLine("Tisse");
            }
            else if ((i%5) == 0)
            {
                Console.WriteLine("mand");
            }
            else if (( i % 3) == 0)
            {
                Console.WriteLine("Tissemand :)");
            } else
            {
                Console.WriteLine(i);
            }

        }
        */
        //opgave 2.06
        /*
        Console.WriteLine("Please enter a number!");
        int inputNumber = Int32.Parse(Console.ReadLine());
        for (int i = 1; i <= inputNumber; i++)
        {
            
            for (int j = 1; j <= 10; j++)
            {
                
                
                    Console.Write($"{i}x{j} = {i*j} ");
                if (j == 10)
                {
                    Console.WriteLine("");
                }
                
            }
        

        }
*/
    }
}
  

