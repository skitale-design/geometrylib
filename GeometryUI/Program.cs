using GeometryLib;

namespace GeometryUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new Triangle(3,4,5).GetSquare()); // 6
            Console.WriteLine(new Circle(1).GetSquare()); // 3.14

            Console.ReadKey();
        }
    }
}
