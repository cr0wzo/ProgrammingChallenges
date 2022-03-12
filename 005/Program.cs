using System;

namespace MyProject
{
    /*
    Project 005: FizzBuzz
    */
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.Write("[{0}] ", i);

                if (i % 3 == 0)
                {
                    Console.Write("Fizz");
                }

                if (i % 5 == 0)
                {
                    Console.Write("Buzz");
                }
                
                Console.WriteLine();
            }
        }
    }
}