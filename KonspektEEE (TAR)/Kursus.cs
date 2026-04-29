using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    class Kursus : MinuKool
    {    
        public static void KuvaInfo(List<Õpetaja> õpetajas)
        {
            Console.WriteLine("Õpetajad:");

            foreach (var õpetaja in õpetajas)
            {
                Console.WriteLine($"{õpetaja.Nimi} - Vanus: {õpetaja.Vanus} - kursuse nime: {õpetaja.Aine} - Palk: {õpetaja.ArvutaPalk()}€");
            }
        }
    } 
}
