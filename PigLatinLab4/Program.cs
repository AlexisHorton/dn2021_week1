using System;

namespace PigLatinLab4
{
    class Program
    {
        static bool StartsWithVowel(char text)
        {
            if (text == 'a' || text == 'e' || text == 'i' || text == 'o' || text == 'u')
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static int FirstVowel(string text)
        {
            int v1 = -1;
            for (int i = 0; i < text.Length; i++)
            {
                if (StartsWithVowel(text[i]))
                {
                    v1 = i;
                    break;
                }
            }
            return v1;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Pig Latin Translator!");
            Console.WriteLine("Enter some text to jumble: \n");
            string text = Console.ReadLine().ToLower();
           
            Console.WriteLine("\n" + text);

            //Console.WriteLine(StartsWithVowel(text)); Double output, hover over method for more info

            //if (StartsWithVowel(text) == true) // add 'way' if begins with vowel
            //{
            //    Console.WriteLine(text + "way");
            //}

            //if (StartsWithVowel(text) == false)
            //{

            //}

            //text = text.Substring(0, 2);
            Console.WriteLine(text.Substring(0, 2) + "ay");

            Console.WriteLine(FirstVowel(text)); // locates position of first vowel
        }
    }
}
