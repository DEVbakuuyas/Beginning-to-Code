namespace Tutorial_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] products = new string[2, 3];

            //Zeile 1
            products[0, 0] = "Senf";             //Spalte 1
            products[1, 0] = "Lebensmittel";     //Spalte 2

            //Zeile 2
            products[0, 1] = "Smartphone";       //Spalte 1
            products[1, 1] = "Elektronik";       //Spalte 2

            //Zeile 3
            products[0, 2] = "Schokolade";       //Spalte 1
            products[1, 2] = "Lebensmittel";     //Spalte 2

            Console.WriteLine(products[0, 0] + " | " + products[1, 0]);
        }
    }
}
