using System;

namespace ifElseDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Some basic comparisons i.e. less than, less than or equal, greater than, greater than or equal, equal, not equal

            int x = 10;
            int y = 5;

            //if (x > y)
            //{
            //    Console.WriteLine("x is indeed greater than y"); // Sort of an answer to the question "is x > y?"
            //    Console.WriteLine("The expression x > y evaluates to true"); // More a response to the statement, "x > y".
            //}

            //if (y > x)
            //{
            //    // If the expression evaulates to true, this code will run
            //    Console.WriteLine("y > x is true");
            //}
            //else
            //{
            //    // If the expression evaluates to false, this code will run
            //    Console.WriteLine("The expression y > x is false");
            //}

            // int size = 649;

            //

            // Although this next code works, it's extra work. After we determine a room is small, we're still checking if a room is medium or large.

            //if (size >= 1 && size <=250)
            //{
            //    Console.WriteLine("Small room");
            //}

            //if (size > 250 && size <650)
            //{
            //    Console.WriteLine("Medium room");
            //}
            //if (size >= 650)
            //{
            //    Console.WriteLine("Large room");
            //}

           
            
            
            int size = 1;

            if ( size >=1 && size <= 250)
            {
                Console.WriteLine("small room");
            }
            else if (size > 250 && size <650)
            {
                Console.WriteLine("Medium room.");
            }
            else 
            {
                Console.WriteLine("Large room");
            }
            Console.WriteLine("All done!");
        }
    }
}
