using System;

namespace UnderstandingAuto_ImplementedProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle
            { Length = 10.0, Width = 20.0 };

            Console.WriteLine("Area of Rectangle: {0}", rect.GetArea());
        }
    }
}
