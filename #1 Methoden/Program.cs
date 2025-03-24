namespace Tutorial_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Begrüßung("Philip");
            Console.ReadKey(); ;
        }

        static void Begrüßung(string name)
        {
            Console.WriteLine("Hallo " + name);
        }
    }
}
