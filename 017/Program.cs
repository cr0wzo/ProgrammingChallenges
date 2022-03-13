using System;

namespace MyProject
{
    /*
    Project 017: Count The Words In A String
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a sentence");
            char[] sentence = Console.ReadLine().ToCharArray();
            
            int count = 0;
            for (int i = 0; i < sentence.Length; i++)
            {
                try
                {
                    if (sentence[i] != ' ' && sentence[i + 1] == ' ')
                    {
                        count++;
                    }
                } catch
                {
                    count++;
                }
                
                Console.WriteLine(sentence[i]);
            }

            Console.WriteLine("There are {0} words in that sentence", count);
        }
    }
}