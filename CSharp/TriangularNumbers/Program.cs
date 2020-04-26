using System;

namespace TriangularNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Loop - {FindNthTerm_Loop(5)}");
            Console.WriteLine($"Recursion - {FindNthTerm_Recursion(5)}");

            Console.ReadKey();
        }

        static int FindNthTerm_Loop(int nth)
        {
            // basically if we have 4 as n, we need to find the 4th triangular term.
            // Thus 4 + 3 + 2 + 1 = 10 

            int total = 0;

            while (nth > 0)
            {
                total += nth--;
            }

            return total;
        }

        static int FindNthTerm_Recursion(int nth)
        {
            // base case 
            if (nth == 1)
                return 1;

            return nth + FindNthTerm_Recursion(nth - 1);
        }
    }
}
