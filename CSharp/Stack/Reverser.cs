namespace Stack
{
    public class Reverser
    {
        private Stackx<string> _stacker;
        private string _reverser;

        public Reverser(string wordToReverseInto)
        {
            _reverser = wordToReverseInto;
        }

        public string ReverseThis()
        {
            InitiliazeStackx();

            string result = string.Empty;

            for (int i = 0; i < _reverser.Length; i++)
            {
                _stacker.Push(_reverser[i].ToString());
            }

            while (!_stacker.IsEmpty())
            {
                result += _stacker.Pop();
            }

            return result;
        }

        private void InitiliazeStackx()
        {
            _stacker = new Stackx<string>(_reverser.Length);
        }
    }
}
