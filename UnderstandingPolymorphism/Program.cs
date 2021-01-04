using System;
using System.Collections.Generic;

namespace UnderstandingPolymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Polygon> polygons = new List<Polygon>();
            //Tipe data List<Polygon> adalah tipe data yang mampu menyimpan sekumpulan objek bertipe Polygon atau tipe objek turunan dari Polygon
            polygons.Add(new Polygon()); //menambahkan objek bertipe Polygon
            polygons.Add(new Rectangle()); //menambahkan objek bertipe Rectangle yang di-cast sebagai Polygon (Polygon p = new Rectangle();)
            polygons.Add(new Triangle()); //menambahkan objek bertipe Triangle yang di-cast sebagai Polygon (Polygon p = new Triangle();)
            
            foreach (Polygon p in polygons)
            {
                p.Draw();
            }
            //foreach di sini sama seperti memanggil method Draw() dari tiap objek Polygon di dalam List polygons
            //polygons[0].Draw(); polygons[1].Draw(); polygons[2].Draw();
        }
    }
}
