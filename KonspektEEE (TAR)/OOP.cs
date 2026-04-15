using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    

    internal class OOP
    {
        /*
        Свойство        Абстрактный класс (abstract class)                                               Интерфейс (interface)
        Назначение      Описывает часть поведения и структуры, которые должны быть переданы подклассам.  Описывает только поведение — то, что должен делать класс.
        Наследование    Класс может наследовать только от одного абстрактного класса.                    Класс может реализовывать несколько интерфейсов одновременно.
        Поля            Может содержать переменные и данные.                                             Не может содержать полей данных.


        🎯 Вывод: Используйте интерфейс, если хотите гарантировать, что совершенно разные классы смогут выполнять одну и ту же задачу (например, Сохраняемый, Печатаемый, Наемный).
            
         */
        public static void OOPTest()
        {
            List<Õpetaja> õpetajaInfo = new List<Õpetaja>
            {
                new Õpetaja { Nimi = "Anna", TunnidNädalas = 20, Tunnitasu = 25, Aine = "Programmeerimine" },
                new Õpetaja { Nimi = "Marko", TunnidNädalas = 18, Tunnitasu = 30, Aine = "Matemaatika" },
                new Õpetaja { Nimi = "Liisa", TunnidNädalas = 22, Tunnitasu = 27, Aine = "Eesti keel" },
                new Õpetaja { Nimi = "Jüri", TunnidNädalas = 16, Tunnitasu = 35, Aine = "Füüsika" },
                new Õpetaja { Nimi = "Katrin", TunnidNädalas = 25, Tunnitasu = 24, Aine = "Keemia" },
                new Õpetaja { Nimi = "Marek", TunnidNädalas = 15, Tunnitasu = 32, Aine = "Ajalugu" },
                new Õpetaja { Nimi = "Sofia", TunnidNädalas = 30, Tunnitasu = 20, Aine = "Inglise keel" },
                new Õpetaja { Nimi = "Peeter", TunnidNädalas = 12, Tunnitasu = 40, Aine = "Kehaline kasvatus" },
                new Õpetaja { Nimi = "Helen", TunnidNädalas = 19, Tunnitasu = 29, Aine = "Geograafia" },
                new Õpetaja { Nimi = "Rasmus", TunnidNädalas = 21, Tunnitasu = 26, Aine = "Muusika" }
            };

           

            List<Õpilane> õpilaneInof = new List<Õpilane>
            {
                new Õpilane { Nimi = "Anna", Klass = 1, Staatus = Õppevorm.Päevane },
                new Õpilane { Nimi = "Marko", Klass = 2, Staatus = Õppevorm.Kaugõpe },
                new Õpilane { Nimi = "Liisa", Klass = 3, Staatus = Õppevorm.Päevane },
                new Õpilane { Nimi = "Jüri", Klass = 4, Staatus = Õppevorm.Ekstern },
                new Õpilane { Nimi = "Katrin", Klass = 5, Staatus = Õppevorm.Päevane },
                new Õpilane { Nimi = "Marek", Klass = 6, Staatus = Õppevorm.Kaugõpe },
                new Õpilane { Nimi = "Sofia", Klass = 7, Staatus = Õppevorm.AkadeemilinePuhkus },
                new Õpilane { Nimi = "Peeter", Klass = 8, Staatus = Õppevorm.Päevane },
                new Õpilane { Nimi = "Helen", Klass = 9, Staatus = Õppevorm.Kaugõpe },
                new Õpilane { Nimi = "Rasmus", Klass = 10, Staatus = Õppevorm.Päevane }
            };

            


            List<MinuKool> minuKools = new List<MinuKool>
            {
                new MinuKool {õpetajas = õpetajaInfo, õpilanes = õpilaneInof}
            };
            visual.palka();


            MinuKool.KuvaKõik(õpetajaInfo, õpilaneInof);


            visual.palka();
            Console.WriteLine("Enter");
            string b = Console.ReadLine();

        }
    }
}
