using System.Security.Cryptography.X509Certificates;

namespace _1._4_Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Person philip = new Person();

            philip.Name = "Philip";
            philip.SageHallo();

            Person simon = new Person();
            simon.Name = "Simon";
            simon.SageHallo();

            Console.ReadKey();
        }
    }

    class Person
    {
        // Eigenschaften
        public string Name { get; set; }
        public int Alter { get; set; }

        // Methoden
        public void SageHallo()
        {
            Console.WriteLine(Name + " sagt: Hallo!");
        }
    }
}
