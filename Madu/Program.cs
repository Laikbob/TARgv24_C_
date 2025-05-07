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
                // Создаём объект Menu и передаем путь к файлу с результатами
                Menu menu = new Menu("game_scores.txt");

                // Запускаем главное меню
                menu.HandleMenuChoice();
            }
        }
    }

