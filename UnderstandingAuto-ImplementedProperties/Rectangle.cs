using System;

namespace UnderstandingAuto_ImplementedProperties
{
    class Rectangle
    {
        private double length; //tidak terpakai
        private double width; //tidak terpakai

        public double Length { get; set; }
        public double Width { get; set; }
        
        public double GetArea()
        {
            return Length * Width;
        }
    }
}
