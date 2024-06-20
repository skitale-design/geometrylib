namespace GeometryLib
{
    public class Triangle
    {
        public float side1 { get; set; }
        public float side2 { get; set; }
        public float side3 { get; set; }

        public Triangle(float side1, float side2, float side3)
        {
            if (IsValidFigure())
            {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
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

        private bool IsValidFigure()
        {
            var arr = new[] { side1, side2, side3 };
            var max = arr.Max();
            var summ = arr.Sum() ;
            bool rezult = (summ - max > max);
            return rezult;
        }
    }

    public class Circle
    {
        public float radius {
            get;
            set;
        }

        public Circle(float radius)
        {
            this.radius = radius;
        }

        public float GetSquare()
        {
            return (float)Math.Round(double.Pi * radius * radius, 2);
        }
    }
}