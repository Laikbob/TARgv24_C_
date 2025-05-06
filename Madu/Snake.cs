using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_.Madu
{
    class Snake : Figure
    {
        public Snake(Point tail, int leght, Derection direction) 
        {
            plist = new List<Point>();
            Point p = new Point(tail);
            p.Move(in, direction);
            plist.Add(p);
        }
    }
}
