using System;

namespace UnderstandingEvents
{
    class Rectangle
    {
        public EventHandler Changed;
        //mendeklarasikan variable bertipe delegate (EventHandler)
        //delegate EventHandler memiliki 2 parameter (object sender, EventArgs e)

        private double length;

        public double Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
                Changed(this, EventArgs.Empty);
                //argument pertama (this) adalah objek Rectangle yang membangkitkan event
                //argument kedua (Empty) adalah field yang memberikan value untuk digunakan dengan event yang tidak memiliki event data
            }
        }
    }
}
