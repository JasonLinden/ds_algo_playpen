using System;

namespace TriangleAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            Console.WriteLine($"Result - {TriangleAnalyzer(int.Parse(Console.ReadLine()))}");

            Console.ReadKey();
        }

        // First basic example of using recursion, important to remember is that we need
        // a base case to allow for the method to prevent infinite recursion and essentially allow the function to compute.
        // We need to reduce the problem by calling the same method, causing the problem to become easier with each itearation
        // Another way of calculating this is by working out (n^2+n)/2
        private static int Triangle(int n)
        {
            if (n == 1)
                return 1;

            return (n + Triangle(n - 1));
        }

        // Analyze this function
        private static int TriangleAnalyzer(int n)
        {
            Console.WriteLine($"Entering: n = {n}");
            if (n == 1)
            {
                Console.WriteLine($"Returning 1");
                return 1;
            }

            int temp = (n + TriangleAnalyzer(n - 1));
            Console.WriteLine($"Returning {temp}");

            return temp;
        }
    }
}
