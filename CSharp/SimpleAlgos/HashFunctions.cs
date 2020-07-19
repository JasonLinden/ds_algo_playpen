namespace SimpleAlgos
{
    public class HashFunctions
    {
        public static int HashFunc1(string key)
        {
            int hashValue = 0;
            int pow27 = 1;

            for (int i = key.Length - 1; i >= 0; i--)
            {
                int letter = key[i] - 96;

                hashValue += pow27 * letter;
                pow27 *= 27;
            }

            return hashValue % 53;
        }

        // Horner's method - overflow is possible with this solution
        public static int HashFunc2(string key)
        {
            int hashValue = key[0] - 96; // get left most letter

            for (int i = 1; i < key.Length; i++) // start at the next letter after 0
            {
                int letter = key[i] - 96;
                hashValue = hashValue * 27 + letter; //(var4*n + var3) first iteration 
            }

            return hashValue % 53;
        }


        // Here we mod at the intermidiate level and not the result, which can help avoid int or long overflows
        public static int HashFunc3(string key)
        {
            int hashValue = 0;

            for (int i = 0; i < key.Length; i++)
            {
                int letter = key[i] - 96;

                hashValue = (hashValue * 27 + letter) % 53;
            }

            return hashValue;
        }
    }
}
