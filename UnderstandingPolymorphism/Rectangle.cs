using System;

namespace UnderstandingPolymorphism
{
    class Rectangle: Polygon
    {
        public override void Draw() //derived class Rectangle meng-override method Draw() dari base class Polygon
        {
            Console.WriteLine("Drawing: Rectangle");
        }
    }
}
