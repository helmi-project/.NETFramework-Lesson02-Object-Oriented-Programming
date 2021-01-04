using System;

namespace UnderstandingPolymorphism
{
    class Polygon
    {
        //Base class Polygon menyediakan method Draw(). Method ini dapat diwariskan ke derived class
        //Keyword virtual digunakan agar derived class dapat meng-override method Draw(). Sekarang derived class dapat memiliki method Draw() dengan implementasinya sendiri
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }
    }
}
