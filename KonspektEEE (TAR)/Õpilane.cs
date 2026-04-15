using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    /*
     // Õpilane pärib klassist Isik  //// Ученик запрашивает из класса «Isik»


        public class Õpilane : Isik
        {
            public string Kool { get; set; }
            public int Klass { get; set; }

            public void Õpi()
            {
                Console.WriteLine($"{Nimi} õpib {Kool} {Klass}. klassis.");
            }
        }
     */

    // Õpilane pärib klassist Isik

    /*
    public class Õpilane : Isik
    {
        public int Klass { get; set; }

        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpilane {Nimi} ja käin {Klass}. klassis.");
        }
    }
    */

    /*
      🔢 6. Тема: Что такое Enum?
      Введение: Enum (перечисление) — это специальный тип данных,
      представляющий группу констант, то есть неизменяемых значений.
      Это помогает избежать опечаток (например, «Päevne» вместо «Päevane») и делает код более читабельным,
      действуя как своего рода выпадающее меню внутри кода.
     */

    public enum Õppevorm
    {
        Päevane,
        Kaugõpe,
        Ekstern,
        AkadeemilinePuhkus
    }

    public class Õpilane : Isik
    {
        public int Klass { get; set; }
        public Õppevorm Staatus { get; set; } // Kasutame enumi andmetüübina

        public override void Kirjelda()
        {
            Console.WriteLine($"{Nimi} õpib: {Klass}. klassis. Vorm: {Staatus}");
        }
    }

    //🎯 Вывод: Enum обеспечивает типовую безопасность и читаемость кода, ограничивая значения переменных строго заданным набором вариантов.

}
