namespace Tutorial_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////int alter = 15;

            ////if (alter >= 18)
            //{
            //    Console.WriteLine("Du darfst die Website betreten");
            //}
            //else
            //{
            //    Console.WriteLine("Du darfst die Website nicht betreten");
            //}

            int alter = 16;
            bool elternDabei = true;
            //bool elternDabei = false; 

            if (alter >= 18)
            {
                Console.WriteLine("Du darfst den Kinofilm schauen");
            }
            else if (alter >= 16 && elternDabei == true)
            {
                Console.WriteLine("Du darfst wegen deinen Eltern ausnahmsweise in den Kinosaal");
            }
            else
            {
                Console.WriteLine("Du darfst den Kinofilm nicht schauen");
            }
        }
    }
}
