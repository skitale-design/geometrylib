﻿using System.Linq;

namespace GeometryLib
{
    public static class Figure
    {
        public static IFigure FigureBuilder(float[] floats)
        {
            switch (floats.Length)
            {
                case 1:
                    return new Circle(floats);
                case 2:
                    throw new NotImplementedException("\nALERT:: The simple Quadrilaterals are not implemented yet.");
                case 3: 
                    return new Triangle(floats);
                default:
                    throw new ArgumentNullException(nameof(floats));
            }
        }
    }
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
                throw new ArgumentOutOfRangeException($"\nERROR:: Params: [{string.Join(", ", _floats)}] Can't build triangle from such lines. Some line is too long. Change params.");
            }
        }

        public float GetArea()
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
                floats = _floats;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"\nERROR:: Params: [{string.Join(", ", _floats)}] The radius must be a positive number. Change the parameter.");
            }
        }

        public float GetArea()
        {
            float radius = floats[0];
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
        float GetArea();
        bool IsValidFigure(float[] floats);
    }

}