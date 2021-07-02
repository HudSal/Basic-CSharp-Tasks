using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Task 05 --- to display the numbers 50 down to 25 with following conditions:
                •	If the number is a multiple of 3, display [3] on the right-side of the number.
                •	If the number is a multiple of 5, display [5] on the right-side of the number.
                •	If the number is a multiple of 3 and 5, display [3 - 5] on the right-side of the number.
           Note: A number is a multiple when it can be evenly divided without a remainder. 
               Your logic must use a loop and only use the Console.WriteLine method a maximum of four times.*/

            for (int i = 50; i >= 25; i--)
            {

                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    Console.WriteLine($"{i} [3 & 5]");
                }
                else if ((i % 5) == 0)
                {
                    Console.WriteLine($"{i} [5]");
                }
                else if ((i % 3) == 0)
                {
                    Console.WriteLine($"{i} [3]");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
