using System;

namespace MyProject
{
    /*
    Project 016: Count The Vowels In A String
    */
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiou";
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            
            int count = 0;
            foreach (char c in sentence.ToLower().ToCharArray())
            {
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            Console.WriteLine("There are {0} vowels in that sentence", count);
        }
    }
}