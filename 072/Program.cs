using System;

namespace MyProject
{
    /*
    Project 072: Text Art
    */
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Write some text :D");
            string word = Console.ReadLine();

            for (int i = 0; i < 3; i++)
            {   
                foreach (char c in word.ToUpper().ToCharArray())
                {   
                    if ("ABCDEFGHIJKLMNOPQRSTUVWXYZ ".Contains(c))
                    {
                        Console.Write(TextArt.charDefinitions[c][i]);
                    }
                }
                Console.WriteLine();
            }   
        }
    }
}