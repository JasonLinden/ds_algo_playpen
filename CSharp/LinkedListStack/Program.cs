namespace LinkedListStack
{
    class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(10);
            stack.Push(30);
            stack.Push(40);
            stack.Push(50); // < -- this is now the top 

            stack.Pop(); // remove 50
            stack.Pop(); // remove 40
            stack.Pop(); // remove 30

            global::System.Console.WriteLine($"{stack.Pop()} should equal 10");
        }
    }
}
