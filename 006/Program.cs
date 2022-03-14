using System;

namespace MyProject
{
    /*
    Project 006: Rock Paper Scissor Lizard Spock
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Moves");    
            Console.WriteLine("[1] Rock");
            Console.WriteLine("[2] Paper");
            Console.WriteLine("[3] Scissors");
            Console.Write("Choice: ");

            Moves[] movePool = new Moves[2];
            movePool[1] = (Moves) new Random().Next(1, 4);

            try
            {
                movePool[0] = (Moves) Convert.ToInt32(Console.ReadLine());

                if ((int) movePool[0] < 1 || (int) movePool[0] > 3)
                {
                    throw new FormatException();
                }
            } catch (FormatException)
            {
                Console.WriteLine("Choose a move from the list");
                Environment.Exit(0);
            }

            Console.WriteLine("You chose {0}, cpu chose {1}", Enum.GetName(typeof(Moves), movePool[0]), Enum.GetName(typeof(Moves), movePool[1]));
            if (movePool[0] == movePool[1])
            {
                Console.WriteLine("Tie! you both picked {0}", Enum.GetName(typeof(Moves), movePool[0]));
            } else if (movePool.Contains(Moves.Rock) && movePool.Contains(Moves.Paper))
            {
                Console.WriteLine("Paper beats rock");
            } else if (movePool.Contains(Moves.Paper) && movePool.Contains(Moves.Scissors))
            {
                Console.WriteLine("Scissors beats paper");
            } else if (movePool.Contains(Moves.Scissors) && movePool.Contains(Moves.Rock))
            {
                Console.WriteLine("Rock beats scissors");
            }
            

        }

        enum Moves
        {
            Rock = 1,
            Paper = 2,
            Scissors = 3
        }
        
    }
}