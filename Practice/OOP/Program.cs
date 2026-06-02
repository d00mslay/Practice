namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle {X = 0, Y = 0, Height = 3, Width = 5 };

            Console.WriteLine(r);
            Console.WriteLine($"Площадь: {r.Square}");
            Console.WriteLine($"Периметр: {r.Perimeter}");
        }
    }
}
