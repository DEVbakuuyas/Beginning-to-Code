namespace Tutorial_7
{
    class Program
    {
        static void Main(string[] args)
        {
            GreetUser("Peter");
        }
        static void GreetUser(string username)
        {
            Console.WriteLine("Hallo" + username + "!");
            Console.WriteLine("Wie geht es dir?");
        }
    }
}
