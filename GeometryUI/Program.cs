using GeometryLib;

namespace GeometryUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Console.WriteLine(new Triangle(30,4,5).GetSquare()); // 6
                Console.WriteLine(new Circle(0).GetSquare()); // 3.14
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            Console.ReadKey();
        }
    }
}
