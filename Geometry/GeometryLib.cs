using System.Linq;

namespace GeometryLib
{
    public class Triangle : IFigure
    {
        public float[] floats { get; }

        public Triangle(float[] _floats)
        {
            if (IsValidFigure(_floats))
            {
                floats = _floats;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"\nParams: [{string.Join(", ", _floats)}] Can't build triangle from such lines. Some line is too long. Change params.");
            }
        }

        public float GetSquare()
        {
            float p = floats.Sum() / 2;
            float tmp = p * (p - floats[0]) * (p - floats[1]) * (p - floats[2]);

            return (float)Math.Round(Math.Sqrt(tmp), 2);
        }

        public bool IsValidFigure(float[] _floats)
        {
            var max = _floats.Max();
            var summ = _floats.Sum() ;
            bool rezult = (summ - max > max);
            return rezult;
        }

        public bool IsRight()
        {
            float hypotenuse = floats.Max();
            float linesSquaresSumm = (floats.Where(x => x != hypotenuse).Select(y => y * y)).Sum();
            return ( hypotenuse*hypotenuse == linesSquaresSumm);
        }


    }

    public class Circle : IFigure
    {
        public float[] floats { get; }
        public float radius { get; set; }

        public Circle(float[] _floats)
        {
            if (IsValidFigure(_floats))
            {
                this.radius = _floats[0];
            }
            else
            {
                throw new ArgumentOutOfRangeException("The radius must be a positive number. Change the parameter.");
            }
        }

        public float GetSquare()
        {
            return (float)Math.Round(double.Pi * radius * radius, 2);
        }

        public bool IsValidFigure(float[] _floats)
        {
            bool rezult = (_floats[0] > 0);
            return rezult;
        }
    }

    public interface IFigure
    {
        float[] floats { get;}
        float GetSquare();
        bool IsValidFigure(float[] floats);
    }

}