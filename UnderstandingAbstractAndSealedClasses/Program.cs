using System;

namespace UnderstandingAbstractAndSealedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10, 20);

            Console.WriteLine("Width = {0}, Length = {1}, Area = {2}", rect.Width, rect.Length, rect.GetArea());
        }
    }
}
