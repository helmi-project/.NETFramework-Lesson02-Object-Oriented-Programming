using System;

namespace UsingTheThisKeyword
{
    class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double l, double w)
        {
            this.length = l; //bisa ditulis dengan atau tanpa this
            this.width = w; //bisa ditulis dengan atau tanpa this
        }
        /*
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        */
        public double GetArea()
        {
            return this.length * this.width; //bisa ditulis dengan atau tanpa this
        }
    }
}
