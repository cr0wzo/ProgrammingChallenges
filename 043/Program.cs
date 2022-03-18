namespace MyProject
{
    /*
    Project 043: Morse Code Shenanigans
    */
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Write a sentence");
            string sentence = Console.ReadLine();

            foreach (char c in sentence.ToUpper().ToCharArray())
            {
                Console.Write(MorseCode.GetSequence(c) + " ");
            }
            
            Console.WriteLine();
        }
    }
}