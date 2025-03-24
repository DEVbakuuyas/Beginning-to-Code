namespace _1._1_Methoden_Rückgabewert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Addition(10, 5));
            Console.ReadKey();
        }

        static int Addition(int zahl1, int zahl2)
        {

            int ergebnis = zahl1 + zahl2;
            return ergebnis;
            //oder return zahl1 + zahl2; // geht auch
        }
    }

}
