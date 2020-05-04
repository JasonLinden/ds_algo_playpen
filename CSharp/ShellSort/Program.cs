using System;

namespace ShellSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var theArray = new int[] { 45, 66, 77, 5, 90, 23, 12, 11, 6, 15, 3, 57, 40, 27 };

            ShellyBeach(theArray);
        }

        static void ShellyBeach(int[] array)
        {
            // we need a gap. - less than n and based off Knuths formula
            // loop over the array until gap is 1.
            // perform insertion sort on elements within an interval of gap.
            // Omce we reach 1, we perform a standard insertion sort but most of the elemets would be 
            // 'almost sorted'.

            // we get a gap
            var h = 1;
            while (h <= array.Length / 3) // divide by 3 eleminated need of if 
            {
                h = h * 3 + 1;
            }

            // loop over until gap os 1
            while (h > 0)
            {
                for (int outer = h; outer < array.Length; outer++)
                {
                    int temp = array[outer];
                    int inner = outer;

                    while (inner > h - 1 && array[inner - h] >= temp)
                    {
                        array[inner] = array[inner - h];
                        inner -= h;
                    }

                    array[inner] = temp;
                }

                h = (h - 1) / 3;
            }
        }
    }
}
