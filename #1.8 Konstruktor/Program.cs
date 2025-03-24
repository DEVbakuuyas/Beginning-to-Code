namespace _1._8_Konstruktor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstelle Objekte der Klasse Mensch - Nutzung des Konstruktors
            Mensch Philip = new Mensch("Philip");
            Mensch Simon = new Mensch("Sisi");

            //Rufe die Methode Begrüßung auf
            Simon.Begrüßung();
            Philip.Begrüßung();

            Console.ReadKey();
        }
    }

    class Mensch
    {
        //Eigenschaften
        public string Name { get; set; }

        //Konstruktor
        public Mensch(string name)
        {
            Name = name;
        }

        // Methoden
        public void Begrüßung()
        {
            Console.WriteLine(Name + " sagt Hallo!");
        }
    }
}
