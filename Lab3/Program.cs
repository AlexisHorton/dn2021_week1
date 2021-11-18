using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            // I can't find where my loop is messing up at. It won't end when appropriate response is entered.

            string entry = "";

            do
            {
                Console.WriteLine("Let's learn squares and cubes!");
                Console.WriteLine("\n Enter a number to continue: ");

                string input = Console.ReadLine();
                double num = double.Parse(input);

                if (num <= 0)
                {
                    Console.WriteLine("Uh oh! That number won't work. Try another.");
                }

                for (double i = 1; i <= num; i++)
                {
                    Console.WriteLine(i);
                }

                for (double i = 1; i <= num; i++)
                {
                    Console.WriteLine(i * i);
                }

                for (double i = 1; i <= num; i++)
                {
                    Console.WriteLine(i * i * i);
                }

                Console.WriteLine("\n Do another? Y/N : ");
                entry = Console.ReadLine().ToLower();

            } while (entry != "N");

            Console.WriteLine("Until next time! :) ");
        }
    }
}
