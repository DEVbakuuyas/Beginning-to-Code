namespace _1._6_Get_und_Set
{
    class Program
    {
        static void Main(string[] args)
        {
            Person philip = new Person();
            philip.Alter = 22;
            Console.WriteLine(philip.Alter);

            Console.ReadKey();
        }
    }

    class Person
    {

        //Private Variablen - Flexibilität der get und set methoden
        private int alter;

        //Eigenschaften
        public string Name { get; set; }
        public int Alter
        {
            get
            {
                Console.WriteLine("Alter wurde gelesen");
                return alter;
            }
            set
            {
                Console.WriteLine("Alter wurde überschrieben");
                alter = value;
            }
        }
    }
}
