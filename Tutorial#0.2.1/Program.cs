namespace Tutorial_2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alter = 30;
            string name = "Peter";
            double größe = 1.82;
            decimal kontostand = 4300.31M;

            Console.WriteLine(name + " sie " + alter + " Jahre alt!");
            Console.WriteLine("Er/Sie ist " + größe + " Meter groß.");
            Console.WriteLine("Sein Kontostand beträgt " + kontostand + " Euro.");
        }
    }
}
