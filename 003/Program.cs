using System;

namespace MyProject
{
    /*
    Project 003: Age To Seconds
    */
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("What's your age in years?");
                int ageInYears = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You are approximately {0} seconds old", ageInYears * 365 * 24 * 3600);
            } catch (FormatException)
            {
                Console.WriteLine("Please input your age as a number");
            }
        }
    }
}