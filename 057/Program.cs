using System;

namespace MyProject
{
    /*
    Project 057: Sort a array
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
            
            bool isSorted = false;
            while (!isSorted)
            {
                // Check If It's Sorted
                for (int i = 0; i < array.Count; i++)
                {
                    try
                    {
                        if (array[i] > array[i + 1])
                        {
                            break;
                        }
                    } catch (ArgumentOutOfRangeException)
                    {
                        isSorted = true;
                    }
                }

                for (int i = 0; i < array.Count; i++)
                {
                    try
                    {
                        if (array[i] > array[i + 1])
                        {
                            int tempInt = array[i];
                            array[i] = array[i + 1];
                            array[i + 1] = tempInt;
                        }
                    } catch (ArgumentOutOfRangeException) {} //Ignored
                }
                
            }

            // Print Sorted Array
            Console.WriteLine(string.Join("", array));

        }
    }
}

//5172951
//1251579