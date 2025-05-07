using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_.Madu
{
    class Program
    {
        static void Main(string[] args)
        {
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            Point p = new Point(4, 5, '*');
            Figure fSnake = new Snake(p, 4, Derection.Right);
            Draw(fSnake);
            Snake snake = (Snake) fSnake;

            HorizontalLine h1 = new HorizontalLine(0,5,6,'&');

            List<Figure> figures = new List<Figure>();
            figures.Add(snake);
            figures.Add(v1);
            figures.Add(h1);

            foreach(var f in figures)
            {
                f.Draw();
            }
        }
        static void Draw (Figure figure)
        {
            figure.Draw();
        }
        //static void Main(string[] args)
        //{   
        //    Console.SetWindowSize(80, 25);


        //    //Границы поля
        //    HorisontalLine upLine = new HorisontalLine(0, 78, 0, '=');
        //    HorisontalLine downLine = new HorisontalLine(0, 78, 24, '=');
        //    VertikalLine leftLine = new VertikalLine(0, 24, 0, '=');
        //    VertikalLine rightLine = new VertikalLine(0,24, 78,'=');
        //    upLine.Draw();
        //    downLine.Draw();
        //    leftLine.Draw();
        //    rightLine.Draw();

        //    // отрисовка точек
        //    Point p = new Point(4,5,'*');
        //    Snake snake = new Snake(p,4, Derection.Right);
        //    snake.Draw();

        //    FoodCreator foodCreator = new FoodCreator(80, 25, '$');
        //    Point food = foodCreator.CreateFood();
        //    food.Draw();

        //    while (true)
        //    {
        //        if (snake.Eat(food))
        //        { 
        //            food = foodCreator.CreateFood();
        //            food.Draw();
        //        }
        //        else
        //        {
        //            snake.Move();
        //        }
        //        Thread.Sleep(100);

        //        if (Console.KeyAvailable)
        //        { 
        //            ConsoleKeyInfo key = Console.ReadKey();
        //            snake.HandleKey(key.Key);
        //        }
        //    }
        //}
      
    }
}
