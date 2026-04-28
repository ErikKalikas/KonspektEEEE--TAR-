using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    public class Üliõpilane : Õpilane
    {

        public string Eriala { get; set; }

        public int Kursus { get; set; }

        

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib: {Kursus} kursus. Vanus: {Vanus} Vorm: {Staatus}. Eriala: {Eriala}");
        }

    }
}
