using GeometryLib;

namespace GeometryUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IFigure> figures = new List<IFigure>();

            try
            {
                figures.Add(new Triangle([3, 4, 5]));
                figures.Add(new Circle([3]));
                figures.Add(new Circle([-1])); // error
                figures.Add(new Triangle([5, 4, 5]));
                figures.Add(new Triangle([10, 4, 5])); //error, but unavailable
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }

            foreach (var figure in figures)
            {
                Console.WriteLine($"S = {figure.GetArea()}"); 
            }

            Console.ReadKey();
        }
    }
}
