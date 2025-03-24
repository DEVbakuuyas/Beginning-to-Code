namespace _1._5_Eigenschaften
{
    class Program
    {
        static void Main(string[] args)
        {
            // Objekt von Person erstellen
            Person person1 = new Person("Philip", 22, "Grünbraun");
            Person person2 = new Person("Simon", 21, "Braun");

            // Eigenschaften anzeigen
            person1.ZeigeEigenschaften();
            person2.ZeigeEigenschaften();

            Console.ReadKey();
        }
    }

    class Person
    {
        // Eigenschaften
        public string Name { get; set; }
        public int Alter { get; set; }
        public string Augenfarbe { get; set; }

        //Konstruktor
        public Person(string name, int alter, string augenfarbe)
        {
            Name = name;
            Alter = alter;
            Augenfarbe = augenfarbe;
        }

        // Methode zur Darstellung der Eigenschaften
        public void ZeigeEigenschaften()
        {
            Console.WriteLine("Name: " + Name + ", Alter: " + Alter + ", Augenfarbe: " + Augenfarbe);
        }
    }
}
