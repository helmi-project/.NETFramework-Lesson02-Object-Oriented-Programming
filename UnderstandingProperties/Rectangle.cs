using System;

namespace UnderstandingProperties
{
    class Rectangle
    {
        private double length;
        private double width;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                if (value > 0.0)
                    length = value;
            }
        }
        public double Width
        {
            get
            {
                return width;
            }
            set
            {
                if (value > 0.0) //value adalah keyword untuk mengecek value yang di-assign
                    width = value;
            }
        }
        public double GetArea()
        {
            return length * width;
        }
    }
}
