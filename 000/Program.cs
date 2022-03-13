using System;

namespace MyProject
{
    /*
    Project 000: Name Generator
    */
    class Program
    {
        static void Main(string[] args)
        {
            const string FirstNameFile = "FirstNames.txt";
            const string LastNameFile = "LastNames.txt";

            Random random = new Random();
            string[] firstNames = File.ReadAllLines(FirstNameFile);
            string[] lastNames = File.ReadAllLines(LastNameFile);

            int randFirstName = File.ReadLines(FirstNameFile).Count();
            int randLastName = File.ReadLines(LastNameFile).Count();

            Console.WriteLine("{0} {1}", firstNames[random.Next(0, randFirstName)], lastNames[random.Next(0, randLastName)]);
        }
    }
}