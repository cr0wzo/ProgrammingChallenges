using System;

namespace MyProject
{
    /*
    Project 040: Largest Number In Array
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a array of ints: ");
            string toArray = Console.ReadLine();
            
            List<int> array = new List<int>();
            foreach (char c in toArray.ToCharArray())
            {
                // If it's a digit, put it in the list
                if ("0123456789".Contains(c))
                {
                    array.Add((int)char.GetNumericValue(c));
                }
            }

            int largest = array[0];
            foreach (int i in array)
            {
                if (largest < i)
                {
                    largest = i;
                }
            }

            Console.WriteLine("The largest num in the array is {0}", largest);
        }
    }
}