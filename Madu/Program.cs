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
            Console.SetWindowSize(80, 25);
            Console.WriteLine("Game started!");

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Draw initial snake
            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 4, Derection.Right);
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("Game loop running... ");

                if (walls.IsHit(snake))
                {
                    Console.WriteLine("Collision with wall!");
                    break;
                }

                if (snake.IsHitTail())
                {
                    Console.WriteLine("Snake hit its own tail!");
                    break;
                }

                if (snake.Eat(food))
                {
                    Console.WriteLine("Food eaten!");
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); // true to prevent char output
                    snake.HandleKey(key.Key);
                }
            }

            Console.WriteLine("Game over. Press any key to exit...");
            Console.ReadKey();

            List<Figure> figures = new List<Figure>();
            figures.Add(snake);

            foreach (var f in figures)
            {
                f.Draw();
            }
        }

        static void Draw(Figure figure)
        {
            figure.Draw();
        }
    }
}