using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    class Koolihaldus : MinuKool
    {
        // Kapseldatud list
        private List<Isik> inimesed = new List<Isik>();

   

        public void LisaInimene(Isik isik)
        {
            inimesed.Add(isik);
        }

        public void KuvaKõik()
        {
            Console.WriteLine("\n--- KOOLI NIMEKIRI ---");
            foreach (var isik in inimesed)
            {
                // Polümorfism teeb siin imesid! 
                // C# teab ise, kas käivitada Õpetaja või Õpilase Kirjelda() meetod.
                isik.Kirjelda();
            }
        }

        public void OtsiNimeJärgi(string otsitavNimi)
        {
            Console.WriteLine($"otsing: {otsitavNimi}");

            foreach (var isik in inimesed)
            {
                /*
                 StringComparison — это перечисление (enum), которое задаёт способ сравнения строк
                 Ordinal — сравнение по символам (быстрое, "как есть")
                 IgnoreCase — игнорировать регистр
                 */
                if (isik.Nimi.Contains(otsitavNimi, StringComparison.OrdinalIgnoreCase))
                {
                    isik.Kirjelda();
                }
            }
        }


        public static void KuvaAinultÕpilased(string otsitavNimi, List<Õpilane> õpilanes)
        {
            int i = 0;
            Console.Clear();
            visual.palka();
            foreach (var õpilane in õpilanes)
            { 
                if (otsitavNimi == õpilane.Nimi)
                {
                    Console.WriteLine($"õpilane {õpilane.Nimi} on kool");
                    Console.WriteLine("");
                    õpilane.Kirjelda();
                    i = 1;
                }
            }

            if (i == 0)
            {
                Console.WriteLine("seda nime ei leitud");
            }
        }
    }
}
