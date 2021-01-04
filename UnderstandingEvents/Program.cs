using System;

namespace UnderstandingEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle();

            r.Changed += new EventHandler(r_Changed);
            //meng-assign method r_Changed() ke delegate. Meng-attach method r_Changed() sebagai EventHandler
            //memanggil delegate Changed akan memanggil method r_Changed()

            r.Length = 10;
            //ketika meng-assign Length (memanggil property Length), delegate Changed (bertipe EventHandler) akan dipanggil
            //memanggil delegate Changed akan memanggil method r_Changed()
        }

        static void r_Changed(object sender, EventArgs e) //method r_Changed dipanggil oleh delegate EventHandler
        {
            Rectangle r = (Rectangle)sender;
            //cast operator untuk mengkonversi tipe data object ke tipe data Rectangle
            
            Console.WriteLine("Value Changed: Length = {0}", r.Length);
        }
    }
}
