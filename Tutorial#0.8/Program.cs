namespace Tutorial_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string username;
            int age;

            Console.Write("Gebe deinen Benutzernamen ein: ");
            username = Console.ReadLine();
            Console.Write("Gebe dein Alter ein: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Dein Name ist " + username + " & du bist " + age + " Jahre alt! ");

        }
    }
}
