using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TARgv24_C;
using static System.Net.Mime.MediaTypeNames;

namespace TARgv24_C
{
    internal class FunktsioonideClass
    {
        public static float Kalkulaator(int arv1, int arv2)
        {
            float kalkulaator = arv1 * arv2;
            return kalkulaator;
        }
        public static string switcKasuta(int a)
        {
            string tekst;
            switch (a)
            {
                case 1: tekst = "E"; break;
                case 2: tekst = "T"; break;
                case 3: tekst = "K"; break;
                case 4: tekst = "N"; break;
                case 5: tekst = "R"; break;
                case 6: tekst = "L"; break;
                
                default:
                    tekst = "Tundmatu";
                    break;
            }
            return tekst; 
        }
        public static string küsiNaber(string nimi1, string nimi2) //Task 1
        {
            string tekst= nimi1+" ja "+nimi2+" täna istusute pinginaabrid";
            return tekst;
        }
        public static float soodus(float s) //Task 3
        {
            float soodus = s * 0.70f;
            return soodus;
        }
        public static void temp(int t) //Taks 4
        {
            if (t > 18)
            {
                Console.Write("Temperatuur on üle 18 kraadi, see on hea toasoojuse jaoks talvel.");
            }
            else
            {
                Console.Write("Temperatuur on alla 18 kraadi, võib olla jahe.");
            }
        }
        public static void pikk(int p) //Task 5
        {
            if (p > 160)
            {
                Console.Write("Lühike pikk");
            }
        }
    }
}