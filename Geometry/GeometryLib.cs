namespace GeometryLib
{
    public class Triangle
    {
        public float side1 {  get; set; }
        public float side2 { get; set; }
        public float side3 { get; set; }

        public Triangle(float side1, float side2, float side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }

        public float GetSquare()
        {
            float p = (side1 + side2 + side3)/2;
            float tmp = p*(p - side1)*(p-side2)*(p-side3);

            return (float)Math.Round(Math.Sqrt(tmp),2);
        }
    }
}
