using System;

namespace UnderstandingInheritance
{
    class Rectangle: Polygon
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        public double GetArea()
        {
            return Width * Length;
        }
    }
}
