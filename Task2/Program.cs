using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            string[] roomType = { "Single", "Double", "Luxury", "Penthouse" };
            decimal[] price = { 45.50m, 99.99m, 165.25m, 1095.50m };

            Console.WriteLine("Room Types\n");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{i + 1}. {roomType[i]} ${price[i]:n} per night");
            }
            Console.Write($"\nPlease select a room type 1, 2, 3 or 4 : ");
            int userRoom = int.Parse(Console.ReadLine()) - 1;
            Console.Write($"Please enter the number of nights : ");
            int numNight = int.Parse(Console.ReadLine());
            string cost = $"{(price[userRoom] * numNight):n}"; // to change the number format and put ',' thousands seperate

            Console.WriteLine($"\nThank you, the total cost for staying in the {roomType[userRoom]} room for {numNight} nights is ${cost}");
            Console.Read();
        }
    }
}
