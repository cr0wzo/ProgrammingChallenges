using System;

namespace MyProject
{
    /*
    Project 040: BMI Calculator
    */
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Weight In Kilograms?");
                int weight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Height Meters?");
                float height = (float) Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine("Your BMI is {0}", weight / (height * height));
            } catch(FormatException)
            {
                Console.WriteLine("Please input a correct amount");
            } 
        }
    }
}