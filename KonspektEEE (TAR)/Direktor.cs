using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    public class Direktor : Õpetaja
    {
        public double Lisatasu { get; set; }

        public override void Kirjelda()
        {
            double b = Lisatasu + ArvutaPalk();
            Console.WriteLine($"Õpetaja: {Nimi}. Vanus: {Vanus} ArvutaPalk: {b}");
        }
    }
}
