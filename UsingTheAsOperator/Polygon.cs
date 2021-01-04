using System;

namespace UsingTheAsOperator
{
    abstract class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        abstract public double GetArea();
    }
}
