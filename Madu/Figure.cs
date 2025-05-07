using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_.Madu
{
    class Figure
    {
        protected List<Point> plist;
        public virtual void Draw()
        {
            foreach (Point p in plist)
            {
                p.Draw();
            }
        }
    }
}
