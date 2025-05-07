using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TARgv24_C_.Madu
{
    class Snake : Figure
    {
        Derection direction;
        public Snake(Point tail, int leght, Derection _direction)
        {
            direction = _direction;
            plist = new List<Point>();
            for (int i = 0; i < leght; i++)
            {
                Point p = new Point(tail);
                p.Move(i, direction);
                plist.Add(p);
            }
        }
        internal void Move()
        {
            Point tail = plist.First();
            plist.Remove(tail);
            Point head = GetNextPoint();
            plist.Add(head);
            
            tail.Clear();
            head.Draw();
        }
        public Point GetNextPoint()
        { 
            Point head = plist.Last();
            Point nextPoint = new Point (head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }
        public void HandleKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Derection.Left;
            else if (key == ConsoleKey.RightArrow)
                direction = Derection.Right;
            else if (key == ConsoleKey.DownArrow)
                direction = Derection.Down;
            else if (key == ConsoleKey.UpArrow)
                direction = Derection.Up;
        }
        internal bool Eat(Point food)
        {
            Point head = GetNextPoint();
            if (head.IsHit (food))
            {
                food.sym = head.sym;
                plist.Add(food);
                return true;
            }
            else
                return false;
        }
    }

}
