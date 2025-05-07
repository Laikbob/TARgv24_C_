using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_.Madu
{
    public class ScoreManager
    {
        private string filePath;

        // Конструктор класса, принимающий путь к файлу
        public ScoreManager()
        {
            // Путь к файлу game_scores.txt, который будет использоваться по умолчанию
            this.filePath = "game_scores.txt";
        }

        // Метод для сохранения очков в файл
        public void SaveScore(string playerName, int score)
        {
            // Формируем строку с результатом игрока
            string scoreLine = $"{playerName}: {score} points";

            // Добавляем строку в файл, создавая файл, если его нет
            File.AppendAllText(filePath, scoreLine + Environment.NewLine);

            // Выводим сообщение
            Console.WriteLine("Your score has been saved to 'game_scores.txt'.");
        }

        // Метод для отображения всех высоких результатов
        public void DisplayScores()
        {
            if (File.Exists(filePath))
            {
                // Читаем все строки из файла
                string[] scores = File.ReadAllLines(filePath);

                // Выводим все результаты
                Console.WriteLine("High Scores:");
                foreach (var score in scores)
                {
                    Console.WriteLine(score);
                }
            }
            else
            {
                // Если файла нет, выводим сообщение
                Console.WriteLine("No scores saved yet.");
            }
        }
    }
}