using System;

namespace UnderstandingTheOverrideAndNewKeywords
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle t = new Triangle(); //objek bertipe Triangle yang memanggil method Draw() akan memanggil method Draw() "baru" yang sudah dibuat ulang
            t.Draw();

            Polygon p = new Triangle(); //objek bertipe Triangle yang di-cast sebagai base class Polygon akan memanggil method Draw() lama yang diimplementasikan di base class Polygon
            //Bisa juga ditulis Polygon p = t;
            p.Draw();
        }
    }
}
