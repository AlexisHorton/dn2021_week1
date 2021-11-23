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
            char first = word[0]; // pulls out one character from 'word', 0 gives the first character of the string.
            // charater type, not a string type, so needs conversion

            return first.ToString(); // converts to a string
        }

        static string GetLastLetter(string word)
        {
            int index = word.Length - 1; // will give us index of last character
            char last = word[index];
            return last.ToString();
        }

        static string GetLastTwo(string word)
        {
            int index = word.Length - 2;
            string last2 = word.Substring(index, 2);
            return last2;
        }

        // Checks if string ends with A or B or C
        static bool EndsWithABC(string word)
        {
            string last = GetLastLetter(word).ToLower();
            if (last == "a" || last == "b" || last == "c")
            {
                return true;
            }
            else
            {
                return false;
            }

            // If you really want to push yourself, understand why we could just do this instead:
            //
            // string last = GetLastLetter(word).ToLower();
            // return (last == "a" || last == "b" || last == "c");
        }


        //
        // Check if first letter is a vowel
        //  Notice that characters use single quotes rather than double quotes
        // To check if first letter is 
        static bool StartsWithaVowel(string word)
        {
            char first = word[0];
            if (first == 'a' || first == 'e' || first == 'i' || first == 'o' || first == 'u') 
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static bool IsVowel(char letter)
        {
            if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // Checks if string ends with ING
        static bool EndsWithING(string word)
        {
            string last3 = word.Substring(word.Length -3).ToLower();
            if (last3 == "ing")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string PigLatin(string word)
        {
            // Put your pig latin conversion in here

            string platin = word;
            return platin;
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

            string yetanother = GetFullName("First", "Last");
            Console.WriteLine(yetanother);

            string last = GetLastLetter("Hello");
            Console.WriteLine(last);

            Console.WriteLine("Substring practice");
            string myword = "programming";
            Console.WriteLine(myword.Substring(4,5)); // first number is where we're starting and the second number is how many characters over from that
            Console.WriteLine(myword.Substring(0,2));

            Console.WriteLine(GetLastTwo(myword));
            Console.WriteLine(GetLastTwo("hello world!"));

            Console.WriteLine("Let's test the EndsWithABC!");
            Console.WriteLine(EndsWithABC("hello"));  //expect false
            Console.WriteLine(EndsWithABC("pizza"));  // expect true
            Console.WriteLine(EndsWithABC("PIZZA"));  // expact true

            Console.WriteLine("Let's test the EndsWithING function");
            Console.WriteLine(EndsWithING("walking")); // expect true
            Console.WriteLine(EndsWithING("walkinG")); // expect true
            Console.WriteLine(EndsWithING("walkiNG")); // expect true
            Console.WriteLine(EndsWithING("walkING")); // expect true
            Console.WriteLine(EndsWithING("walkin"));  // expect false
            Console.WriteLine(EndsWithING("walkiN")); // expect false

            //how to build a string: Piece together a string
            string letters = "";
            for (int i=0; i<=10; i++)
            {
                letters += 'x';
            }
            Console.WriteLine(letters);

            // Another way: Locate the first vowel
            string test = "christmas";
            int firstVowel = -1;
            for (int i=0; i < test.Length; i++)
            {
                if (IsVowel(test[i]))
                {
                    firstVowel = i;
                    break;
                }
            }
            Console.WriteLine(firstVowel);
        }
    }
}
