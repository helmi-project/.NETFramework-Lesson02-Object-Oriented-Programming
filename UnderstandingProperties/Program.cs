using System;

namespace UnderstandingProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();

            rect.Length = 10.0;
            rect.Width = 20.0;
            Console.WriteLine("Length: {0}", rect.Length);
            Console.WriteLine("Width: {0}", rect.Width);

            double area = rect.GetArea();
            Console.WriteLine("Area of Rectangle: {0}", area);
        }
    }
}
