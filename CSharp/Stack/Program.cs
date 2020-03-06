using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Please enter a string and press enter:");
                var word = Console.ReadLine();

                var reveser = new Reverser(word);
                Console.Write(reveser.ReverseThis());
                Console.WriteLine();
            }
        }
    }
}
