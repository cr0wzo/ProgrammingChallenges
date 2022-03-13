using System;

namespace MyProject
{
    /*
    Project 013: Magic Eight Ball
    */
    class Program
    {
        static void Main(string[] args)
        {
            string[] responses = 
            {
                "It is certain", "It is decidedly so", "Without a doubt", "Yes — definetly",
                "You may rely on it", "As I see it, yes", "Most likely", "Outlook good",
                "Yes", "Signs point to yes", "Reply hazy, try again", "Ask again later",
                "Better not tell you know", "Cannot predict now", "Concentrate and ask again", "Don't count on it",
                "My reply is no", "My sources say no", "Outlook not so good", "Very doubtful"
            };
            
            Console.WriteLine("Magic 8ball says: {0}", responses[new Random().Next(0,20)]);
        }
    }
}