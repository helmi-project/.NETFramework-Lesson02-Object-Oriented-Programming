using System;

namespace UnderstandingMemoryAllocationWithStructs
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
    public struct Point //struct tidak diletakkan di dalam class
    {
        public double X, Y;
    }
}
