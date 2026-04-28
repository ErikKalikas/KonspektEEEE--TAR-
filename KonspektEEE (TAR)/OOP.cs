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
                new Õpetaja { Nimi = "Anna", TunnidNädalas = 20, Tunnitasu = 25, Aine = "Programmeerimine", Vanus = 17 },
                new Õpetaja { Nimi = "Marko", TunnidNädalas = 18, Tunnitasu = 30, Aine = "Matemaatika", Vanus = 35 },
                new Õpetaja { Nimi = "Liisa", TunnidNädalas = 22, Tunnitasu = 27, Aine = "Eesti keel", Vanus = 29 },
                new Õpetaja { Nimi = "Jüri", TunnidNädalas = 16, Tunnitasu = 35, Aine = "Füüsika", Vanus = 41 },
                new Õpetaja { Nimi = "Katrin", TunnidNädalas = 25, Tunnitasu = 24, Aine = "Keemia", Vanus = 33 },
                new Õpetaja { Nimi = "Marek", TunnidNädalas = 15, Tunnitasu = 32, Aine = "Ajalugu", Vanus = 38 },
                new Õpetaja { Nimi = "Sofia", TunnidNädalas = 30, Tunnitasu = 20, Aine = "Inglise keel", Vanus = 27 },
                new Õpetaja { Nimi = "Peeter", TunnidNädalas = 12, Tunnitasu = 40, Aine = "Kehaline kasvatus", Vanus = 45 },
                new Õpetaja { Nimi = "Helen", TunnidNädalas = 19, Tunnitasu = 29, Aine = "Geograafia", Vanus = 31 },
                new Õpetaja { Nimi = "Rasmus", TunnidNädalas = 21, Tunnitasu = 26, Aine = "Muusika", Vanus = 36 }
            };



            List<Õpilane> õpilaneInof = new List<Õpilane>
            {
                new Õpilane { Nimi = "Anna", Klass = 1, Staatus = Õppevorm.Päevane, Vanus = 29 },
                new Õpilane { Nimi = "Marko", Klass = 2, Staatus = Õppevorm.Kaugõpe, Vanus = 18 },
                new Õpilane { Nimi = "Liisa", Klass = 3, Staatus = Õppevorm.Päevane, Vanus = 17 },
                new Õpilane { Nimi = "Jüri", Klass = 4, Staatus = Õppevorm.Ekstern, Vanus = 19 },
                new Õpilane { Nimi = "Katrin", Klass = 5, Staatus = Õppevorm.Päevane, Vanus = 16 },
                new Õpilane { Nimi = "Marek", Klass = 6, Staatus = Õppevorm.Kaugõpe, Vanus = 20 },
                new Õpilane { Nimi = "Sofia", Klass = 7, Staatus = Õppevorm.AkadeemilinePuhkus, Vanus = 21 },
                new Õpilane { Nimi = "Peeter", Klass = 8, Staatus = Õppevorm.Päevane, Vanus = 15 },
                new Õpilane { Nimi = "Helen", Klass = 9, Staatus = Õppevorm.Kaugõpe, Vanus = 18 },
                new Õpilane { Nimi = "Rasmus", Klass = 10, Staatus = Õppevorm.Päevane, Vanus = 17 }
            };




            List<MinuKool> minuKools = new List<MinuKool>
            {
                new MinuKool {õpetajas = õpetajaInfo, õpilanes = õpilaneInof}
            };
            visual.palka();


            MinuKool.KuvaKõik(õpetajaInfo, õpilaneInof);



            Üliõpilane u1 = new Üliõpilane() //4
            {
                Nimi = "Mark",
                Kursus = 2,
                Staatus = Õppevorm.Päevane,
                Eriala = "IT",
                Vanus = 19
            };
            Koolihaldus kool = new Koolihaldus();
            kool.LisaInimene(u1);
            kool.KuvaKõik();

            visual.palka();

            //test 4 ül
            {
                while (true)
                {
                    Console.WriteLine("Kirjuta sinu nimi");
                    string nimi11 = Console.ReadLine();


                    int vanus11 = 1;
                    try
                    {
                        Console.WriteLine("Kirjuta sinu vanus");
                        vanus11 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception a)
                    {
                        Console.Clear();
                        Console.WriteLine(a);
                        Console.WriteLine("");
                        continue;
                    }

                    int kursus11 = 1;
                    try
                    {
                        Console.WriteLine("Kirjuta sinu kursus");
                        kursus11 = int.Parse(Console.ReadLine());
                    }
                    catch (Exception a)
                    {
                        Console.Clear();
                        Console.WriteLine(a);
                        Console.WriteLine("");
                        continue;
                    }

                    Console.WriteLine("Kirjuta sinu Eriala");
                    string Eriala11 = Console.ReadLine();



                   

                    try
                    {
                        Üliõpilane u2 = new Üliõpilane() //4
                        {
                            Nimi = nimi11,
                            Kursus = kursus11,
                            Staatus = Õppevorm.Päevane,
                            Eriala = Eriala11,
                            Vanus = vanus11
                        };

                        kool.LisaInimene(u2);
                        kool.KuvaKõik();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Palun sisesta number!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Sisestatud number on liiga suur või väike!");
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Viga: {ex.Message}");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Tekkis tundmatu viga!");
                    }

                    break;
                }

                
            }


            visual.palka();
            Console.WriteLine("Enter");
            string b = Console.ReadLine();

        }
    }
}
