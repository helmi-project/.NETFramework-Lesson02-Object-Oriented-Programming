using System;

namespace UnderstandingClasses
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            length = l;
            width = w;
        }
        public double GetArea()
        {
            return length * width;
        }
        public void InitFields(double l, double w)
        {
            length = l;
            width = w;
        }
    }
}
