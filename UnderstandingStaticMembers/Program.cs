using System;

namespace UnderstandingStaticMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle //cara membuat instance class dan meng-assign auto-implemented properties
            { Length = 10.0, Width = 20.0 };

            Console.WriteLine("Shape Name: {0}, Area: {1}", Rectangle.ShapeName, rect.GetArea());
        }
    }
}
