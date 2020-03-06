using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    public class MatchingBrackets
    {
        private readonly string _stringToMatch;
        private readonly string[] OP_SYMBOLS = new string[] { "{", "[", "(" };
        private readonly string[] CL_SYMBOLS = new string[] { "}", "]", ")" };

        public MatchingBrackets(string stringToMatch)
        {
            _stringToMatch = stringToMatch;
        }

        public void Check()
        {
            var stackx = new Stackx<string>(_stringToMatch.Length);

            for (int i = 0; i < _stringToMatch.Length; i++)
            {
                char a = _stringToMatch[i];

                if (ContainsOPSymbols(a))
                {
                    stackx.Push(a.ToString()); // Here we push all left delimilter onto the stack
                    continue;
                }
                else if (ContainsCLSymbols(a))
                {
                    // If the item is a right delimiter then we can check for it's left counterpart
                    if (!stackx.IsEmpty())
                    {
                        var matchingItem = stackx.Pop();

                        // essentially for this to be right the first item popped off the stack must definitely be 
                        // the matching left delimiter.
                        if (!isMatchingPair(matchingItem, a.ToString()))
                        {
                            Console.WriteLine($"Error {a} at {i}");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error {a} at {i}");
                        break;
                    }
                }
            }

            // If we get here, that means there is still an item on the stack, which is a left delimiter.
            if (!stackx.IsEmpty())
                Console.WriteLine("Missing right delimiter");
        }

        private bool ContainsOPSymbols(char character)
        {
            return OP_SYMBOLS.Contains(character.ToString());
        }

        private bool ContainsCLSymbols(char character)
        {
            return CL_SYMBOLS.Contains(character.ToString());
        }

        private static bool isMatchingPair(string character1, string character2)
        {
            if (character1 == "(" && character2 == ")")
                return true;
            else if (character1 == "{" && character2 == "}")
                return true;
            else if (character1 == "[" && character2 == "]")
                return true;
            else
                return false;
        }
    }
}
