using System;

namespace UnderstandingAbstractAndSealedClasses
{
    sealed class Rectangle : Polygon //sealed class tidak bisa diturunkan
    {
        public Rectangle(double length, double width)
        {
            Length = length;
            Width = width;
        }

        sealed public override double GetArea() //sealed member tidak bisa di-override di class turunan
        {
            return Width * Length;
        }
    }
}
