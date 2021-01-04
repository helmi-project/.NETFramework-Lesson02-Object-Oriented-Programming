using System;

namespace UsingTheAsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = new Rectangle(10, 20);

            //Operator as mirip seperti operator is, tapi jika tipe konversi tidak memungkinkan, null akan dikembalikan dan tidak memunculkan exception
            Rectangle r = o as Rectangle;
            //Pengecekan if dilakukan untuk mengecek apakah hasil cast tidak mengembalikan null
            if (r != null)
            {
                Console.WriteLine(r);
            }
            //Jika saat runtime tidak memungkinkan untuk meng-cast value dari variable o (Object) ke r (Rectangle), maka value null akan di-assign ke variable r (Rectangle)
        }
    }
}
