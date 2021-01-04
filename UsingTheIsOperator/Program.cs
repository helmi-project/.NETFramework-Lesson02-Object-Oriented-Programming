using System;

namespace UsingTheIsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Rectangle(10, 20);

            //Untuk menghindari error InvalidCastException ketika casting, operator is dapat digunakan untuk mengecek apakah cast dibolehkan
            if (o is Rectangle)
            {
                Rectangle r = (Rectangle)o;
                Console.WriteLine(r);
            }
        }
    }
}
