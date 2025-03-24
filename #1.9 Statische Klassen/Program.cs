namespace _1._9_Statische_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Aufruf der statischen Methode ohne Objekterstellung
            Mensch.Name = "Simon";
            Mensch.Begrüßung();

            //Ändern des Namens und erneutem Aufruf der statischen Methode
            Mensch.Name = "Philip";
            Mensch.Begrüßung();

            Console.ReadKey();
        }
    }

    static class Mensch
    {
        //Statische Eigenschaft
        public static string Name { get; set; }

        //Statische Methode
        public static void Begrüßung()
        {
            Console.WriteLine(Name + " sagt Hallo!");
        }
    }
}
