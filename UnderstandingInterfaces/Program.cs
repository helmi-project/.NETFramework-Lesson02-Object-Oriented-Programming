using System;

namespace UnderstandingInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle
            { Length = 10, Width = 20 };

            Rectangle rect2 = new Rectangle()
            { Length = 100, Width = 200 };

            Console.WriteLine(rect1.CompareTo(rect2));
            Console.WriteLine(rect2.CompareTo(rect1));
            Console.WriteLine(rect1.CompareTo(rect1));

            /*//akan menghasilkan error
            Polygon rect3 = new Polygon();
            //{ Length = 100, Width = 200 };
            Console.WriteLine(rect1.CompareTo(rect3));
            */
        }
    }
}
