using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reapeat 150 times
            for (int i = 1; i <= 150; i++ ) 
            {
                Console.WriteLine($"Ive outputed  {i}  times");
            }


            //repeat until yes
            bool areNearlyThereYet = false;

            while(areNearlyThereYet == false)
            {
                Console.WriteLine("Are we nearly there yet?");
                areNearlyThereYet = Console.ReadLine().ToLower() =="yes";
            }

            //repeats from 1 to 50
            for (int i = 1; i < 50; i++)
            {
                //say if number is odd or even
                string oddoreven = "odd";
                if (i % 2 == 0)
                {
                    oddoreven = "even";
                }
                Console.WriteLine($"{i} is {oddoreven}");
                
                //say if divisble by 3
                string oddoreven2 = "not divisible by 3";
                if (i % 3 == 0)
                {
                    oddoreven2 = "divisible by 3";
                }
                Console.WriteLine($"{i} is {oddoreven2}");

            }


            Console.ReadLine();


        }
    }
}
