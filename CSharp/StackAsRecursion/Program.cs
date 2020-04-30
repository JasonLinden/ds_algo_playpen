using System;

namespace StackAsRecursion
{
    // Read page 325

    class Program
    {
        static int _answer;
        static int _number;
        static int _address;
        static Params _params;
        static Stacker<Params> stackx;

        static void Main(string[] args)
        {
            recTriangle();

            Console.WriteLine($"{_answer}");

            whileTriangle();

            Console.WriteLine($"{_answer}");

            Console.ReadKey();
        }

        private static void whileTriangle()
        {
            stackx = new Stacker<Params>(10000);
            _number = 4;
            _answer = 0;

            while (_number > 0)
            {
                _params = new Params(_number, 1);
                stackx.Push(_params);

                --_number;
            }

            while (!stackx.IsEmpty())
            {
                var newNumber = stackx.Pop();
                _answer += newNumber.number;
            }
        }

        private static void recTriangle()
        {
            stackx = new Stacker<Params>(10000);
            _address = 1;
            _number = 4;

            while (Step() == false) ;
        }

        private static bool Step()
        {
            switch (_address)
            {
                // Initial call
                case 1:
                    _params = new Params(_number, 6);
                    stackx.Push(_params);
                    _address = 2;
                    break;
                // enter the recursiveness
                case 2:
                    _params = stackx.Peek();

                    // This is similar to the base case
                    if (_params.number == 1)
                    {
                        _answer = 1;
                        _address = 5;
                    }
                    else
                        _address = 3; // recursive call
                    break;
                case 3:
                    // recursively going deeper and adding all the numbers to stack before we get to 1
                    // Once we get to 1, we will return and aggregate
                    var newparams = new Params(_params.number - 1, 4);
                    stackx.Push(newparams);
                    _address = 2;
                    break;
                // calculate the result
                case 4:
                    _params = stackx.Peek();
                    _answer += _params.number;
                    _address = 5;
                    break;
                case 5:
                    _params = stackx.Peek();
                    _address = _params.returnAddress;
                    stackx.Pop();
                    break;
                case 6:
                    return true;
            }

            return false;
        }
    }

    class Params
    {
        public int number;
        public int returnAddress;

        public Params(int nn, int ra)
        {
            number = nn;
            returnAddress = ra;
        }
    }
}
