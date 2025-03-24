namespace _2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Erstelle Objekte der abgeleiteten Klasse Student
            Student Philip = new Student("Philip", "Informatik");
            Student Simon = new Student("Simon", "Biologie");

            //Aufruf der Methode aus der Basisklasse, aber in der abgeleiteten Klasse überschrieben
            Simon.Begrüßung();
            Philip.Begrüßung();

            Console.ReadKey();
        }
    }

    //Basisklasse Mensch
    class Mensch
    {
        //Eigenschaft
        public string Name { get; set; }

        //Konstruktor
        public Mensch(string name)
        {
            Name = name;
        }

        //Methode, die in der abgeleiteten Klasse überschrieben werden kann
        public virtual void Begrüßung()
        {
            Console.WriteLine(Name + " sagt Hallo!");
        }
    }

    //Abgeleitete Klasse Student
    class Student : Mensch
    {
        //Eigenschaft für den Studiengang
        public string Studiengang { get; set; }

        //Konstruktor der abgeleiteten Klasse
        public Student(string name, string studiengang) : base(name)
        {
            Studiengang = studiengang;
        }

        //Überschreiben der Methode Begrüßung aus der Basisklasse
        public override void Begrüßung()
        {
            Console.WriteLine(Name + " ist Student im Studiengang " + Studiengang + " und sagt Hallo!");
        }
    }
}
