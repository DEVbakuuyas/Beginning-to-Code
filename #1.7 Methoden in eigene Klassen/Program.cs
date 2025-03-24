namespace _1._7_Methoden_in_eigene_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensch Philip = new Mensch();
            Mensch Simon = new Mensch();
            Simon.Name = "Sisi";
            Simon.Begrüßung();
            Philip.Name = "Philip";
            Philip.Begrüßung();

            Console.ReadKey();
        }
    }

    class Mensch
    {
        //Eigenschaften
        public string Name { get; set; }

        //Methoden - nicht statische Methode - wird nur über das Objekt Mensch aufgerufen
        public void Begrüßung()
        {
            Console.WriteLine(Name + " sagt Hallo!");

        }
    }
}
