using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            //add logic here

            char[] chararr = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            int[] count = new int[26];

            StreamReader reader = new StreamReader("characters.txt");
            while (!reader.EndOfStream)
            {
                char charc = (char)reader.Read();
                for (int i = 0; i < chararr.Length; i++)
                {
                    if (charc==chararr[i])
                    {
                        count[i]++;
                    }
                }
            }
            reader.Dispose();

            StreamWriter sw = new StreamWriter("../../character-count.txt");
                for (int i = 0; i < 26; i++)
                {
                    sw.WriteLine($"{chararr[i]} {count[i]}");
                }
               
                sw.Dispose();
            Console.ReadKey();
            
        }
    }
}
