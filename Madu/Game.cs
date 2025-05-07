using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_.Madu
{
    class Game
    {
        private string playerName;
        private ScoreManager scoreManager;

        public Game(string playerName, ScoreManager scoreManager)
        {
            this.playerName = playerName;
            this.scoreManager = scoreManager;
        }

        public void Run()
        {
            Console.Clear();
            // Инициализация консоли
            Console.SetWindowSize(80, 25);
            Console.CursorVisible = false;

            // Инициализация объектов
            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Начальная позиция змейки
            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 4, Derection.Right);
            snake.Draw();

            // Создание еды
            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            // Переменная для подсчёта очков
            int score = 0;

            // Главный игровой цикл
            while (true)
            {
                Console.SetCursorPosition(0, 0);

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
                    score++;  // Увеличиваем счёт за съеденную еду
                    Console.SetCursorPosition(0, 1);
                    Console.WriteLine($"Score: {score}");

                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                // Задержка для управления скоростью игры
                Thread.Sleep(100);

                // Обработка нажатия клавиш для изменения направления змейки
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true); // true - чтобы не выводить символ
                    snake.HandleKey(key.Key);
                }
            }

            // Игра окончена, выводим результаты
            Console.WriteLine("Game over. Press any key to exit...");
            Console.ReadKey();

            // Сохраняем результаты в файл через ScoreManager
            scoreManager.SaveScore(playerName, score);
        }
    }
}
