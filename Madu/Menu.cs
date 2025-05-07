using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_.Madu
{
    class Menu
    {
        private ScoreManager scoreManager;

        public Menu(string filePath)
        {
            scoreManager = new ScoreManager(filePath);
        }

        // Метод для отображения главного меню
        public void Display()
        {
            Console.Clear();

            // Пример использования WriteText для отображения линии
            int xOffset = 1;
            int yOffset = 10;
            Console.WriteLine("============================", xOffset, yOffset++);

            Console.WriteLine("Welcome to Snake Game!");
            Console.WriteLine("1. Start Game");
            Console.WriteLine("2. View High Scores");
            Console.WriteLine("3. Exit");
            Console.Write("Select an option (1-3): ");
            
            Console.WriteLine();
            Console.WriteLine("============================", xOffset, yOffset++);
        }

        // Метод для обработки выбора меню
        public void HandleMenuChoice()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Display();
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        StartGame();
                        break;
                    case "2":
                        ViewHighScores();
                        break;
                    case "3":
                        isRunning = false;
                        Console.WriteLine("Exiting the game...");
                        break;
                    default:
                        Console.WriteLine("Invalid option! Please select again.");
                        break;
                }
            }
        }

        // Метод для запуска игры
        private void StartGame()
        {
            // Prompt for player name
            Console.Write("Enter your name: ");
            string playerName = Console.ReadLine();

            // Create the Game object and start the game
            Game game = new Game(playerName, scoreManager);
            game.Run();

            // Game is running, menu should not interfere
            // After game finishes, display the menu again or prompt for next action
            Console.Clear();
            Console.WriteLine("Game over! Press any key to return to the menu.");
            Console.ReadKey();
        }

        // Method to display high scores
        private void ViewHighScores()
        {
            Console.Clear();
            scoreManager.DisplayScores();
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}