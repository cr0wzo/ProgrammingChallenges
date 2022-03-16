using System;
namespace MyProject
{
    /*
    Project 004: Caesar Cipher
    */
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Write some text");
            string text = Console.ReadLine();
            Console.WriteLine("Input a key (number)");
            int key;

            try 
            {
                key = Convert.ToInt32(Console.ReadLine());
                CaesarCipher cipher = new CaesarCipher(key, "abcdefghijklmnopqrstuvwxyz");
                Console.WriteLine("===Enc===\n" + cipher.Encode(text));
                Console.WriteLine("===Dec===\n" + cipher.Decode(cipher.Encode(text)));
            } catch (FormatException)
            {
                Console.WriteLine("Input the key as number");
                Environment.Exit(1);
            }
        }
    }
}