namespace _1._3_OOP
{
    // Definition der Klasse Person
    class Person
    {
        // Eigenschaften (Attribute)
        public string Name { get; set; }
        public int Alter { get; set; }

        // Konstruktor
        public Person(string name, int alter)
        {
            Name = name;
            Alter = alter;
        }

        // Methode zur Darstellung der Personendaten
        public void ZeigeInfo()
        {
            Console.WriteLine("Name: " + Name + ", Alter: " + Alter);
        }
    }

    // Hauptprogramm
    class Program
    {
        static void Main()
        {
            // Objekte erstellen
            Person person1 = new Person("Philip", 30);
            Person person2 = new Person("Simon", 25);

            // Methodenaufruf zur Anzeige der Daten
            person1.ZeigeInfo();
            person2.ZeigeInfo();
        }
    }
}