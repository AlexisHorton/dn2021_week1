using System;

namespace MethodPractice
{
    class Program
    {
        static void ShowHelp()
        {
            Console.WriteLine("Welcome to the program.");
            Console.WriteLine("Please choose an option.");
            Console.WriteLine("When you are done, you can click N.");
        }

        static string GetFullName(string FirstName, string LastName)
        {
            return FirstName + " " + LastName;
        }

        static string GetFirstLetter (string word)
        { 
            char first = word[0]; // pulls out one character from 'word', 0 gives the first character.
            return first.ToString(); // converts to a string
        }

        static void Main(string[] args)
        {
            ShowHelp();

            string fullname = GetFullName("Sally", "Smith");
            Console.WriteLine(fullname);

            string anothername = GetFullName("Fred", "Franklin");
            Console.WriteLine(anothername);

            string firstletter = GetFirstLetter("Hello");
            Console.WriteLine(firstletter);
        }
    }
}
