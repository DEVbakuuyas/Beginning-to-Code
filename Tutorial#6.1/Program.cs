namespace Tutorial_6._1
{
    class Program
    {
        static void Main()
        {
            int zahl = 20;

            do 
            {
                zahl++;
                Console.WriteLine(zahl); //Es wird 21 rauskommen, weil sie mindestens einmal ausgeführt wird
            }   while (zahl < 10);
            
        }
    }
}
