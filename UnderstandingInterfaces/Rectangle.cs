using System;

namespace UnderstandingInterfaces
{
    class Rectangle : Polygon, IComparable
    {
        public double Length { get; set; }
        public double Width { get; set; }

        public override void Draw()
        {
            Console.WriteLine("Drawing: Rectangle");
        }
        public double GetArea()
        {
            return Length * Width;
        }

        /*
         * Jika objek pemanggil method CompareTo() areanya lebih besar dibandingkan dengan objek dalam parameter method CompareTo(), maka hasilnya 1
         * Jika objek pemanggil method CompareTo() areanya lebih kecil dibandingkan dengan objek dalam parameter method CompareTo(), maka hasilnya -1
         * Jika objek pemanggil method CompareTo() areanya sama dengan dibandingkan dengan objek dalam parameter method CompareTo(), maka hasilnya 0
         * Jika argument yang diberikan ke parameter method CompareTo() bukan merupakan objek Rectangle, maka akan melempar exception
         */
        public int CompareTo(object obj)
        {
            if (obj == null) //jika argument kosong
                return 1; //akan mengembalikan 1. Otomatis objek pemanggil method CompareTo() nilai areanya lebih besar

            if (!(obj is Rectangle)) //jika argument bukan bertipe Rectangle
                throw new ArgumentException(); //akan melempar exception

            Rectangle target = (Rectangle)obj; //argument objek di-cast kembali ke tipe Rectangle dengan reference baru, target

            double diff = this.GetArea() - target.GetArea(); //this.GetArea(), this-nya adalah objek pemanggil method CompareTo

            if (diff == 0)
                return 0;
            else if (diff > 0)
                return 1;
            else return -1;
        }
    }
}
