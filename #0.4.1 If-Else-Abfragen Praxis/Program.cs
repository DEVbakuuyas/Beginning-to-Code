namespace Tutorial_7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 12;

            if (CheckAge(age))
                Console.WriteLine("Du bist volljährig");
            else
                Console.WriteLine("Du bist minderjährig");
        }

        static bool CheckAge(int age)
        {
            return age >= 18;
        }
    }
}
