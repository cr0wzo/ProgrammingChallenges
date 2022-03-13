using System;

namespace MyProject
{
    /*
    Project 001: Heads Or Tails
    */
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            
            if (random.Next(0,2) == 0)
            {
                Console.WriteLine("Heads!");
            } else 
            {
                Console.WriteLine("Tails!");
            }
        }
    }
}