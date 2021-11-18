using System;

namespace NumAnalyze1
{
    class Program
    {
        static void Main(string[] args)
        {
            // WriteLine for a new line after statement; Write is the keep input on the same line.

            //Console.WriteLine("First text");
            //Console.Write("Second text");
            //Console.Write("Third text");
            //Console.WriteLine("Fourth text");


            Console.Write("Please enter a number between 1 and 100:");
            string entry = Console.ReadLine();
            int num = int.Parse(entry);
            Console.WriteLine($"\nYou entered: {entry}. ");
                        //Console.WriteLine(entry); is the same as ^ "$ + {text}/ called "string interpolation"
            //if (num % 2 == 1 && num < 60)
            //{
            //    Console.WriteLine($"{num} Odd and less than 60.");
            //}
            //else if (num % 2 == 0 && num >= 2 && num <= 24)
            //{
            //    Console.WriteLine($"{num} is even and less then 25.");
            //}
            //else if (num % 2 == 0 && num >= 26 && num <= 60)
            //{
            //    Console.WriteLine($"{num} is even and between 26 and 60 inclusive.");
            //}
            //else if (num % 2 == 0 && num > 60)
            //{
            //    Console.WriteLine($"{num} is even and greater than 60.");
            //}
            //else if (num % 2 == 1 && num > 60)
            //{
            //    Console.WriteLine($"{num} is odd and greater than 60.");
            //}

            // Version 2

            Console.WriteLine("\n Here's version 2");

            if (num % 2 == 1)
            {

                if (num < 60)
                {
                    Console.WriteLine($"{num} is odd and less than 60.");
                }
                else
                {
                    Console.WriteLine($"{num} is odd and greater than 60.");
                }
            }
            else
            {
                if (num >= 2 && num <= 24)
                {
                    Console.WriteLine($"{num} is even and less than 25.");
                }
                else if (num >= 26 && num <=60)
                {
                    Console.WriteLine($"{num} is even and between 26 and 60 inclusive.");
                }
                else
                {
                    Console.WriteLine($"{num} is even and greater than 60");
                }
            }
        }
    }
}
