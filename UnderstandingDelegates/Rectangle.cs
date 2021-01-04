using System;

namespace UnderstandingDelegates
{
    public class Rectangle
    {
        private double length;
        private double width;

        public RectangleHandler handler;
        //mendeklarasikan variable bertipe delegate (RectangleHandler)
        //variable ini dapat merefer ke method apa saja asal dengan signature yang sama dengan delegate-nya
        //dibuat public agar bisa diakses di class yang berbeda

        public Rectangle(double l, double w)
        {
            this.length = l; //bisa ditulis dengan atau tanpa this
            this.width = w; //bisa ditulis dengan atau tanpa this
        }

        public double GetArea()
        {
            return this.length * this.width; //bisa ditulis dengan atau tanpa this
        }

        public void GetFields()
        {
            Console.WriteLine("Length = {0}", this.length);
            Console.WriteLine("Width = {0}", this.width);
        }
    }

    public delegate void RectangleHandler(Rectangle rect);
    //menetapkan delegate yang dapat menyimpan reference (Rectangle)
    //ke method yang hanya bertipe void dan hanya menerima satu parameter bertipe Rectangle (DisplayArea())
}
