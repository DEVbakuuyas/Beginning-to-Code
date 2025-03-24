namespace Tutorial_7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = RectangleArea(8, 5);
            Console.WriteLine("Das Rechteck hat eine Fläche von " + area);
        }

        static double RectangleArea(double width, double height)
        {
            return width * height;
        }
    }
}
