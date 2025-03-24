namespace _1._2_Foreach_Schleifen
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlenListe = new int[5];

            zahlenListe[0] = 10;
            zahlenListe[1] = 20;
            zahlenListe[2] = 30;
            zahlenListe[3] = 40;
            zahlenListe[4] = 50;

            foreach (int zahl in zahlenListe)
            {
                Console.WriteLine(zahl);
            }

            Console.ReadKey();
        }
    }
}
