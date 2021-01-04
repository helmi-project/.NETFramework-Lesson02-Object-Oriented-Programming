using System;

namespace CastingBetweenTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Polygon p = new Rectangle(10, 20); //membuat objek Rectangle dan meng-cast-nya ke tipe base class Polygon

            Object o = new Rectangle(10, 20); //meng-assign objek Rectangle ke tipe ultimate base class Object
            Rectangle r = (Rectangle)o; //meng-cast kembali objek Object ke tipe Rectangle dengan reference baru, r. Cara aman menggunakan operator is/as

            Console.WriteLine(r);
        }
    }
}
