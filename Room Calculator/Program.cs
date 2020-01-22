using System;

namespace Room_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue = "y";
            while (userContinue != "n")
            {
                //input
                Console.WriteLine("Room length?");
                double roomLength = double.Parse(Console.ReadLine());

                Console.WriteLine("Room width?");
                double roomWidth = double.Parse(Console.ReadLine());

                Console.WriteLine("Room Height?");
                double roomHeight = double.Parse(Console.ReadLine());

                //output
                double perimeter = roomLength * roomWidth;
                double area = (2 * roomLength) + (2 * roomWidth);
                double volume = roomLength * roomWidth * roomHeight;

                Console.WriteLine($"The perimeter of the room is: {perimeter}");
                Console.WriteLine($"The area of the room is: {area}");
                Console.WriteLine($"The volume of the room is: {volume}");

                //ask questions again
                Console.WriteLine("Would you like to try another room? (y/n)");
                userContinue = Console.ReadLine().ToLower();
            }






        }
    }
}
