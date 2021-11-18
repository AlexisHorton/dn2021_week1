using System;

namespace NumAnalyze2
{
    class Program
    {

        static bool IsOddUner60(int num)
        {       // Checking the expression for either true or false
            if (num % 2 == 1 && num < 60)
            {
                // When the expression comes back true, return true
                return true;
            }
            else
            {
                // When the expression comes back false, return false
                return false;
            }
        }

        static bool IsOddOver60(int num)
        {
            return num % 2 == 1 && num > 60;
        }

        static void Main(string[] args)
        {
            int x = 61;
            if (IsOddUner60(x) == true)
            {
                Console.WriteLine($"{x} is odd under 60.");
            }
            else if (IsOddOver60(x) == true)
            {
                Console.WriteLine($"{x} is odd and over 60.");
            }
        }
    }
}
