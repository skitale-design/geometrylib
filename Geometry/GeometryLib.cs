using System.Linq;

namespace GeometryLib
{
    public class Triangle
    {
        public float side1 { get; set; }
        public float side2 { get; set; }
        public float side3 { get; set; }

        public Triangle(float _side1, float _side2, float _side3)
        {
            if (IsValidFigure(_side1,_side2,_side3))
            {
                this.side1 = _side1;
                this.side2 = _side2;
                this.side3 = _side3;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Can't build triangle from such lines. Some line is too long. Change params.");
            }
        }

        public float GetSquare()
        {
            float p = (side1 + side2 + side3) / 2;
            float tmp = p * (p - side1) * (p - side2) * (p - side3);

            return (float)Math.Round(Math.Sqrt(tmp), 2);
        }

        private bool IsValidFigure(float _side1, float _side2, float _side3)
        {
            var arr = new[] { _side1, _side2, _side3 };
            var max = arr.Max();
            var summ = arr.Sum() ;
            bool rezult = (summ - max > max);
            return rezult;
        }

        public bool IsRight()
        {
            float[] arr = { side1, side2, side3 };
            float hypotenuse = arr.Max();
            float linesSquaresSumm = (arr.Where(x => x != hypotenuse).Select(y => y * y)).Sum();
            return ( hypotenuse*hypotenuse == linesSquaresSumm);
        }


    }

    public class Circle
    {
        public float radius {get;set;}

        public Circle(float _radius)
        {
            if (IsValidFigure(_radius))
            {
                this.radius = _radius;
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

        private bool IsValidFigure(float _radius)
        {
            bool rezult = (_radius > 0);
            return rezult;
        }
    }
}