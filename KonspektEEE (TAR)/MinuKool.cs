using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    class MinuKool
    {
        public List<Õpetaja> õpetajas { get; set; }
        public List<Õpilane> õpilanes { get; set; }

        public void KuvaKõik()
        {
            Console.WriteLine("Õpetajad:");

            foreach (var õpetaja in õpetajas)
            {
                Console.WriteLine($"{õpetaja.Nimi} - {õpetaja.Aine} - {õpetaja.ArvutaPalk()}€");
            }

            Console.WriteLine("Õpilased:");

            foreach (var õpilane in õpilanes)
            {
                Console.WriteLine($"{õpilane.Nimi} - {õpilane.Klass}. klass - {õpilane.Staatus}");
            }
        }
    }
}
