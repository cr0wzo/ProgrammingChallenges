using System;

namespace MyProject
{
    /*
    Project 002: Temperature Converter
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Temperature Converter--");
            Console.WriteLine("[1] °F to °C");
            Console.WriteLine("[2] °C to °F");
            string option = Console.ReadLine();

            if (option.Equals("1"))
            {
                try
                {
                    Console.WriteLine("Temperature in fahrenheit:");
                    float amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} °F -> {1} °C", amount, (amount - 32) * 5 / 9);
                } catch (FormatException)
                {
                    Console.WriteLine("Input a correct amount!");
                }
            } else if (option.Equals("2"))
            {
                try
                {
                    Console.WriteLine("Temperature in celsius:");
                    float amount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("{0} °C -> {1} °F", amount, 1.8 * amount + 32);
                } catch (FormatException)
                {
                    Console.WriteLine("Input a correct amount!");
                }
            } else
            {
                Console.WriteLine("Please choose a option");
            }
        }
    }
}