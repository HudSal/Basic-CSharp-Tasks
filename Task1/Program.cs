using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* TASK 01 ----- project for processing a mathematical expression
            on two integer values with a single operator*/


            Console.Write("Enter an integer value: ");
            int fnum = int.Parse(Console.ReadLine());

            Console.Write("Enter an operator [ Subtract '-' , Plus '+' , Multiply '*' or Division '/' ]: ");
            char op = Console.ReadKey().KeyChar;

            Console.Write("\nEnter another integer value: ");
            int snum = int.Parse(Console.ReadLine());

            double total;
            switch (op)
            {
                case '+':
                    total = fnum + snum;
                    Console.WriteLine($"{fnum} plus {snum} equals {total}");
                    break;
                case '-':
                    total = fnum - snum;
                    Console.WriteLine($"{fnum} minus {snum} equals {total}");
                    break;
                case '*':
                    total = fnum * snum;
                    Console.WriteLine($"{fnum} times {snum} equals {total}");
                    break;
                case '/':
                    total = (double)fnum / snum;
                    Console.WriteLine($"{fnum} divided {snum} equals {total}");
                    break;

                default:
                    Console.WriteLine("Wrong Operator");
                    break;
            }

            Console.ReadLine();
        }
    }
}
