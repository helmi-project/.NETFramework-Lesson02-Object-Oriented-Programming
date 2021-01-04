using System;

namespace UnderstandingDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(10.0, 20.0);

            rect.handler += new RectangleHandler(DisplayArea);
            //meng-assign method DisplayArea() ke delegate
            //Dapat juga ditulis
            //handler = DisplayArea;

            rect.handler += TampilkanField;
            //Bisa menambahkan lebih dari 1 method ke dalam delegate asal dengan signature yang sama dengan delegate-nya

            rect.handler(rect);

            //----------------------------------------------------------------------------------------------------
            Rectangle rect2 = new Rectangle(2.0, 4.0);
            rect2.handler += new RectangleHandler(DisplayArea);
            rect2.handler(rect2);
        }

        static void DisplayArea(Rectangle rect) //method ini dienkapsulasi. Memiliki method signature yang sama dengan delegate
        {
            Console.WriteLine(rect.GetArea());
        }

        static void TampilkanField(Rectangle rect)
        {
            rect.GetFields();
        }
    }
}
