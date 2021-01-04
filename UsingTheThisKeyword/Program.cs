using System;

namespace UsingTheThisKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);

            Console.WriteLine(rect.GetArea());
        }
    }
}
