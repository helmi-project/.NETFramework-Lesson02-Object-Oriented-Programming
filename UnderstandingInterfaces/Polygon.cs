using System;

namespace UnderstandingInterfaces
{
    class Polygon
    {
        //Base class Polygon menyediakan method Draw(). Method ini dapat diwariskan ke derived class
        //Keyword virtual digunakan agar derived class dapat meng-override method Draw(). Sekarang derived class dapat memiliki method Draw() dengan implementasinya sendiri
        //Derived class yang mengimplementasikan kembali method Draw(), harus menyertakan keyword override atau new. Jika tidak maka compiler akan menganggap keyword new yang digunakan
        public virtual void Draw()
        {
            Console.WriteLine("Drawing: Polygon");
        }
    }
}
