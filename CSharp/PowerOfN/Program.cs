using System;

namespace PowerOfN
{
    class Program
    {
        // This problem is solved by reducing the number of multiplications needed
        // when raising x to power y.

        // For example, if we say x^4 we know we need to multiply x four times, x * x * x * x
        // However, we can reduce the number of multiplications here assuming that (x^2)^2 is the same as x^4
        // Or in other words - x^y = (x^2)^y/2
        // So (x^2)^2 is now only 2 multiplications. Firstly x *x and the result of that * y/2
        static void Main(string[] args)
        {
            Console.WriteLine($"I got the power {Pow(3, 18)}");
        }

        public static int Pow(int x, int y)
        {
            if (y == 1)
                return x * y;

            if (y % 2 != 0)
            {
                var result = Pow(x * x, y / 2);
                return result * x;
            }

            return Pow(x * x, y / 2);
        }
    }
}
