using System;

namespace UnderstandingStaticMembers
{
    class Rectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        
        public double GetArea()
        {
            return this.Length * this.Width;
        }

        public static string ShapeName //static field ShapeName bertipe string
        {
            get { return "Rectangle"; } //memiliki dan mengembalikan value "Rectangle"
        }
    }
}
