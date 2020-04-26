using System;

namespace Anagrams
{
    class Program
    {
        static int _size;
        static char[] wordInArray;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to perform an anagram..");
            var word = Console.ReadLine();

            _size = word.Length;

            wordInArray = word.ToCharArray();

            AnagramInstagram(_size);
        }

        // Basically we drill down to 1 item and the return the base case which allows us to 
        // display the word. We then rotate based on 2 items and display the word again. -- cat (display), cta (display), then we rotate again to cat (no display) 
        // Because we return the function call.

        // We then return from that function all AnagramInstagram(2) to AnagramInstagram(3) which is -- atc and i from main loop = 1 becuase we are now onto the next iteration of words
        // where we rotate the word again based on 3 letters.

        // Here we repeat the top paragraph
        static void AnagramInstagram(int newSize)
        {
            // base case
            if (newSize == 1)
                return;

            for (int i = 0; i < newSize; i++)
            {
                AnagramInstagram(newSize - 1);

                if (newSize == 2)
                    DisplayWord();

                Rotate(newSize);
            }
        }

        private static void Rotate(int newSize)
        {
            int j;
            var position = _size - newSize;
            char temp = wordInArray[position]; // save the first letter

            for (j = position + 1; j < _size; j++)
            {
                wordInArray[j - 1] = wordInArray[j];
            }

            wordInArray[j - 1] = temp; // assign the last letter to the end of elements we are dealing with.
        }

        private static void DisplayWord()
        {
            for (int i = 0; i < _size; i++)
            {
                Console.Write(wordInArray[i]);
            }

            Console.WriteLine("");
        }
    }
}
