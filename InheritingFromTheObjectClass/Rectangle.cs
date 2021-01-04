using System;

namespace InheritingFromTheObjectClass
{
    class Rectangle : Polygon
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public override double GetArea()
        {
            return Width * Length;
        }

        public override string ToString()
        {
            return string.Format("Width = {0}, Length = {1}", Width, Length);
        }
    }
}
