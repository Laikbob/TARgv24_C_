using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TARgv24_C;
using static System.Net.Mime.MediaTypeNames;

namespace TARgv24_C_
{
    internal class MainClass
    {
        public static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Tere! Hea Päeva!");

            //// 1.osa Andmetüüpd, If, Case, Random, Alamfuktsioonid
            //int a = 0;
            //string tekst = "Python";
            //char taht = 'A';
            //double arv = 5.544454564;
            //float arv1 = 2;

            //Console.Write("Mis on sinu nimi? ");
            //tekst = Console.ReadLine();
            //Console.WriteLine("Tere!\n" + tekst);
            //Console.WriteLine("Tere!\n{0}", tekst);

            //if (tekst.ToLower() == "juku")
            //{
            //    Console.WriteLine("Lahme kinno!");
            //    try
            //    {
            //        Console.WriteLine("{0}\nKui vana sa oled?", tekst);
            //        int vanus = int.Parse(Console.ReadLine());

            //        if (vanus <= 0 || vanus > 100)
            //        {
            //            Console.WriteLine("Viga!");
            //        }
            //        else if (vanus <= 6)
            //        {
            //        }
            //        else if (vanus <= 15)
            //        {
            //            Console.WriteLine("Lastepilet");
            //        }
            //        else if (vanus <= 65)
            //        {
            //            Console.WriteLine("Standartpilet");
            //        }
            //        else if (vanus <= 100)
            //        {
            //            Console.WriteLine("Vanapilet");
            //        }
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine(e.Message);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Olen hõivatud!");
            //}

            //Random rnd = new Random();

            //Console.WriteLine("Arv 2: ");
            //int arv2 = int.Parse(Console.ReadLine());

            //arv1 = FunktsioonideClass.Kalkulaator(a, arv2);
            //Console.WriteLine(arv1);

            //a = rnd.Next();

            ////Task nädal
            //Console.WriteLine("Switch'i kasutamine");
            //a = rnd.Next(1, 7);
            //Console.WriteLine(a);

            //tekst = FunktsioonideClass.switcKasuta(a);
            //Console.WriteLine(tekst);

            //Console.ReadKey();

            //Task1  naber
            //Console.Write("Sisesta esimene inimese nimi: ");
            //string nimi1 =Console.ReadLine();
            //Console.Write("Sisesta teine inimese nimi: ");
            //string nimi2 = Console.ReadLine();
            //string neigbor = FunktsioonideClass.küsiNaber(nimi1, nimi2);
            //Console.WriteLine(neigbor);

            ////Task 2 pikkus
            //Console.Write("Sisesta toa pikkus (meetrites): ");
            //string pikkus = Console.ReadLine();
            //Console.Write("Sisesta toa laius (meetrites): ");
            //string toa= Console.ReadLine();



            //Task 3 soodus
            Console.Write("Sisesta toote hind pärast 30% soodustust: ");
            float s = float.Parse(Console.ReadLine());
            float soodust = FunktsioonideClass.soodus(s);
            Console.WriteLine(soodust);

            //Task 4 temp
            Console.Write("Kui palju temperatuur on õues");
            int t =int.Parse(Console.ReadLine());
            FunktsioonideClass.temp(t);

            //Task 5 pikkus
            Console.Write("Mis pikkus teil on ?");
            int p = int.Parse(Console.ReadLine());
                

        }

    }
}