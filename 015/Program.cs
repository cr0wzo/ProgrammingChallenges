using System;

namespace MyProject
{
    /*
    Project 015: Reverse a string
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();
            char[] splitSentence = sentence.ToCharArray();

            for (int i = splitSentence.Length - 1; i >= 0 ; i--)
            {
                Console.Write(splitSentence[i]);
            } Console.WriteLine();
        }
    }
}