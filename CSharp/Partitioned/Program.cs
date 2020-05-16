using System;

namespace Partitioned
{
    public class Program
    {
        static int[] _theArray;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        // The gist of this algorithm is we loop until the two pointers (left and right) overlap, 
        // While we do that, we traverse the left side of the array looking for a value larger than the pivot value,
        // We do the same for the right side.
        // Once we find two values, larger (left) and smaller (right) than the pivot, we swap them.

        // We are not concerned with the order of the elements once they are partitioned (hence almost sorted)

        public static void Partition(int left, int right, int pivot)
        {
            // we want to start one index to the left and to the right.
            int leftPrt = left - 1;
            int rightPrt = right + 1;

            // Keep going until paths cross
            while (leftPrt < rightPrt)
            {
                while (leftPrt < right && // This is so it doesnt go off the end of the array.
                    _theArray[++leftPrt] < pivot)
                    ;

                while (rightPrt > left && // This is so it doesnt go off the end of the array.
                    _theArray[--rightPrt] > pivot)
                    ;

                // Once we get to this point we can be sure that the two values need to be swapped.
                Swap(leftPrt, rightPrt);
            }
        }

        private static void Swap(int leftPrt, int rightPrt)
        {
            int temp = _theArray[leftPrt];
            _theArray[leftPrt] = _theArray[rightPrt];
            _theArray[rightPrt] = temp;
        }
    }
}
