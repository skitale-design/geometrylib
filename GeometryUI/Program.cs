using GeometryLib;

namespace GeometryUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var datas = new List<float[]>()
            {
                new float[] {3, 4, 5 },
                new float[] {3},
                new float[] {3,3},
                new float[] {-1},
                new float[] {5, 4, 5},
                new float[] {10, 4, 5},
                new float[] {}
            };

            List<IFigure> figures = new List<IFigure>();

            foreach (var data in datas)
            {
            try
            {
                    figures.Add(Figure.FigureBuilder(data));
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
