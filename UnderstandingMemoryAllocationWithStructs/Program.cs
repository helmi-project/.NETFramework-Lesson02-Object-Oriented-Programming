using System;

namespace UnderstandingMemoryAllocationWithStructs
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1; //variable bertipe struct bisa dibuat tanpa menggunakan keyword new
            //bisa juga dituliskan Point p1 = new Point();

            p1.X = 10;
            p1.Y = 20;

            Point p2 = p1; //p2 akan meng-copy value dari p1. Masing-masing value independent
            p2.X = 100;

            Console.WriteLine("p1.X = {0}", p1.X);
            Console.WriteLine("p2.X = {0}", p2.X);

            Rectangle rect1 = new Rectangle
            { Length = 10.0, Width = 20.0 };

            Rectangle rect2 = rect1; //rect2 akan merujuk ke objek yang sama dengan rect1
            rect2.Length = 100.0;

            Console.WriteLine("rect1.Length = {0}", rect1.Length);
            Console.WriteLine("rect2.Length = {0}", rect2.Length);
            //ketika meng-copy variable tipe reference ke variable lain dengan tipe reference yang sama, maka hanya reference-nya saja yang di-copy
            //hasilnya, setelah meng-copy, kedua variable akan merujuk ke objek yang sama (address dan value rect2)
        }
    }
}
