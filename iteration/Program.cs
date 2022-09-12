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

           
                Console.ReadLine();


        }
    }
}
