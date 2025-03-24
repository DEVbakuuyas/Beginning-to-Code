namespace Tutorial_5
{
    class Program
    {
        static void Main()
        {
            int wochentag = 5;   // Freitag wird mir angezeigt, da er bis case 5 abfragt & nur das zeigt

            switch(wochentag)   //zu prüfende Variable
            {
                case 1:          //Definition eines Case (Falls)
                    Console.WriteLine("Montag");
                    break;       //herausspringen aus Switch-Block

                case 2:
                    Console.WriteLine("Dienstag");
                    break;

                case 3:
                    Console.WriteLine("Mittwoch");
                    break;

                case 4:
                    Console.WriteLine("Donnerstag");
                    break;

                case 5:
                    Console.WriteLine("Freitag");
                    break;

                default:        //Default-Case sollte keiner der Fälle zutreffen
                    Console.WriteLine("Ungültiger Wochentag");
                    break;


            }
        }
    }
}
