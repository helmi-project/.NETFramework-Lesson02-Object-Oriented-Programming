using System;

namespace UnderstandingTheOverrideAndNewKeywords
{
    class Triangle: Polygon
    {
        //Derived class Triangle "membuat ulang dengan nama yang sama" method Draw() dari base class Polygon, dan menyembunyikan implementasi asli dari base class Polygon
        public new void Draw()
        {
            Console.WriteLine("Drawing: Triangle");
        }
    }
}
