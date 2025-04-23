using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TARgv24_C_._3.Tund
{
    internal class MainClass_ylesannedcs
    {
        public static void Main(string[] args)
        {
            // 1. Loo failinimi Kuud.txt
            string path = FunktsioonideClass3osa.FailiPath(@"C:\Users\opilane\source\repos\TARgv24_C_\3.Tund\Kuud.txt");

            // 2. Kirjuta programmi abil 3 kuud faili
            FunktsioonideClass3osa.FailiKirjutamine(path);

            // 3. Loe kuud List<string> sisse
            List<string> kuude_list = FunktsioonideClass3osa.FailiLugemine(path);

            // 4. Eemalda „Juuni“, muuda esimene element
            FunktsioonideClass3osa.EemaldamineMuutmine(path, kuude_list);

            // 5. Kuvada kõik kuud
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // 6. Luba kasutajal otsida kuud nime järgi
            Console.WriteLine("Sisesta kuu nimi, mida otsida:");
            string otsitav_kuu = Console.ReadLine();
            string vastus = FunktsioonideClass3osa.Otsing(otsitav_kuu, kuude_list);
            Console.WriteLine(vastus);

            // 7. Salvesta muudatused faili tagasi
            FunktsioonideClass3osa.Salvestamine(path, kuude_list);

        }
    }
}
