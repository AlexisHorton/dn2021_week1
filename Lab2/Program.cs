using System;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Number Analyzer/Decision Maker! \n");
            Console.WriteLine("Please enter your name \n");
            string name = Console.ReadLine();
            Console.WriteLine("\nHi " + name + "! :) \n");

            Console.WriteLine("\n Now, enter an integer between 1 and 100.");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            if (number < 1 || number > 100)
            {
                Console.WriteLine("\n Oops! That's not a valid entry!");
            }
            if (number %2 != 0 && number < 60)
            {
                Console.WriteLine(name + ", you chose " + number + " which is odd & less than 60.");
            }
            else if (number %2 != 0 && number > 60) 
            {
                Console.WriteLine(name + ", you chose " + number + " which is odd & greater than 60.");
            }
            if (number %2 == 0 && number >= 2 && number <= 24)
            {
                Console.WriteLine(name + ", you chose " + number + " which is even & less than 25.");
            }
            else if (number %2 == 0 && number >= 26 && number <= 60)
            {
                Console.WriteLine(name + ", you chose " + number + " which is even & between 26 and 60 inclusive.");
            }
            else if (number %2 == 0 && number > 60)
            {
                Console.WriteLine(name + ", you chose " + number + " which is even and greater than 60.");
            }
            Console.WriteLine("\n See ya! :P");
        }
    }
}
