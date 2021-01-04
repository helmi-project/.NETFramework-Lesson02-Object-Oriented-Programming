using System;

namespace UnderstandingPolymorphism
{
    class Triangle: Polygon
    {
        public override void Draw() //derived class Triangle meng-override method Draw() dari base class Polygon
        {
            Console.WriteLine("Drawing: Triangle");
        }
    }
}
