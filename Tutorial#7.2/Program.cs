namespace Tutorial_7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMultipleMessages("Hallo Welt", 3);
            PrintMultipleMessages("Hello World!", 10);
        }

        static void PrintMultipleMessages(string message, int count)
        {
            while (count > 0)
            {
                Console.WriteLine(message);
                count--;
            }
        }
    }
}
