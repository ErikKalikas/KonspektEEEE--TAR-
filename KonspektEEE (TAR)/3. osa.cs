using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    internal class ClassOsa3
    {
        public static void konspekt()
        {
            Console.OutputEncoding = Encoding.UTF8;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("gg");

            }

            int j = 0;
            while(j<10)
            {
                Console.WriteLine("tere");
                j++;
            }
            int a = 0;
            do
            {
                Console.WriteLine(a);
                a++;
                j++;
            }
            while (j == 20);

            int[] arvud = new int[5];

            for (int i=0; i<arvud.Length; i++)
            {
                Console.WriteLine($"{i+1}arv");
                try
                {
                    Console.WriteLine($"записать в масив в {i} из {arvud.Length}");
                    arvud[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
                
            }

            //int[] uusMasiv = ClassOsa3.masiv1();


        }
        public static int[] masiv1(int[] masiv)
        {
            Console.WriteLine("сколько ячеек в масиве");
            masiv = new int[Convert.ToInt32(Console.ReadLine())];
            for (int i = 0; i < masiv.Length; i++)
            {
                Console.WriteLine($"записать в масив в ячейку {i} из {masiv.Length}");
                masiv[i] = int.Parse(Console.ReadLine());
            }
            return masiv;
        }
        //------------------------------------------------------------------------


        //Teoria

        public static void Teoria()
        {
            List<Isik> inimesed = new List<Isik>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Sisesta nimi: ");
                string nimi = Console.ReadLine();

                Console.Write("Sisesta vanus: ");
                int vanus = int.Parse(Console.ReadLine());

                Isik uusIsik = new Isik();
                uusIsik.Nimi = nimi;
                uusIsik.Vanus = vanus;

                inimesed.Add(uusIsik);
            }

            Console.WriteLine("\nKõik inimesed tervitavad:\n");

            foreach (Isik isik in inimesed)
            {
                isik.Tervita();
            }


            //------------------------------------------------------------------------


            string[] nimed = new string[8] { "A", "B", "C", "D", "E", "F", "G", "H" };
            nimed[2] = "Anna";
            int nr = 0;
            while (nr < 8)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr = nr + 1;
            }
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[i]);
            }
            foreach (var nimi in nimed)
            {
                Console.WriteLine("Tere, {0} õpilane", nimi);
            }
            nr = 0;
            do
            {
                Console.WriteLine("Tere, {0} õpilane", nimed[nr]);
                nr++;
            } while (nr != nimed.Length);


            //------------------------------------------------------------------------


            //Tuple

            //Tuple<T1, T2, T3> — это структура данных, в которой можно хранить несколько значений разных типов вместе, не создавая отдельный класс или структуру.
            //Создание кортежа:
            Tuple<float, char, string> minuTuple = new Tuple<float, char, string>(3.14f, 'A', "Programmeerimine");

            Console.WriteLine("Esimene: " + minuTuple.Item1); // 3.14
            Console.WriteLine("Teine: " + minuTuple.Item2);   // A
            Console.WriteLine("Kolmas: " + minuTuple.Item3);  // Programmeerimine


        }
        //------------------------------------------------------------------------

        //Ülesanded

        public static (int, int) GenereeriRuudud(int min, int max)
        {
            min = 0;
            max = 0;

            Random rnd = new Random();
            int number = rnd.Next(min, max); 


            return (min, max);
        }

    }

}
