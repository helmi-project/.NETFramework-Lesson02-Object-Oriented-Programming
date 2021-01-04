using System;

namespace InheritingFromTheObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);

            Console.WriteLine(rect); //bisa juga ditulis rect.ToString()
        }
    }
}
