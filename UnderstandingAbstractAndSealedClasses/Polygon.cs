using System;

namespace UnderstandingAbstractAndSealedClasses
{
    abstract class Polygon
    {
        public double Length { get; protected set; }
        public double Width { get; protected set; }

        abstract public double GetArea();
    }
}
