using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's calculate the area and perimeter of your room! \n");
            Console.WriteLine("Enter the length amount: \n");

            string length = Console.ReadLine();
            double lenNum = double.Parse(length);

            Console.WriteLine("Now enter the width amount: \n");

            string width = Console.ReadLine();
            double widNum = double.Parse(width);
            double area = lenNum * widNum;

            Console.WriteLine("\n The area of your room is" + " " + area);
            if (area <= 250)
            {
                Console.WriteLine("\n This is a small-sized room.");
            }
            else if (area < 650)
            {
                Console.WriteLine("\n This is a medium-sized room.");
            }
            else if (area >= 650)
            {
                Console.WriteLine("\n This is a large-sized room.");
            }

            double perimeter = (2 * lenNum) + (2 * widNum);

            Console.WriteLine("\n The perimeter of your room is" + " " + perimeter);

            Console.WriteLine("Let's get the volume and surface area just for kicks and giggles. \n");
            Console.WriteLine("Enter the height amonut: \n");

            string height = Console.ReadLine();
            double heiNum = double.Parse(height);
            double volume = lenNum * widNum * heiNum;

            Console.WriteLine("\n The volume of your room is" + " " + volume);

            double surfaceArea = (2 * lenNum * heiNum) + (2 * lenNum * widNum) + (2 * widNum * heiNum);

            Console.WriteLine("\n The room's surface area is" + " " + surfaceArea);

            Console.WriteLine("\n Thanks for using the Room Detail Generator! :)");

        }
    }
}
