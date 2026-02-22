using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static KonspektEEE__TAR_.ClassOsa3;

namespace KonspektEEE__TAR_
{
    internal class ClassOsa3
    {
        public static void palka()
        {
            Console.WriteLine("");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");
        }

        public static void konspekt() //konspekt
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
        internal class ArvuTöötlus
        {
            public static int[] GenereeriRuudud() //1. Juhuslike arvude ruudud
            {
                Random rnd = new Random();
                int arv1 = rnd.Next(1, 15);
                int arv2 = rnd.Next(1, 15);
                int[] masivv = new int[15];
                int min = 0;
                int max = 0;

                Console.WriteLine($"{arv1}  {arv2}");
                Console.WriteLine("");


                if (arv1 < arv2)
                {
                    min += arv1;
                    max += arv2;
                }
                else if (arv1 > arv2)
                {
                    min += arv2;
                    max += arv1;
                }
                else
                {
                    masivv[arv1] = arv2;
                    Console.WriteLine(masivv[arv2]);
                    return masivv;
                }


                for (int i = min; i <= max; i++)
                {
                    masivv[i] = i;
                    Console.WriteLine(masivv[i]);
                }
                palka();
                for (int i = min; i <= max; i++)
                {
                    masivv[i] = i * i;
                    Console.WriteLine($"{i} * {i} = {masivv[i]}");
                }

                return masivv;
            }
            //2. Viie arvu analüüs
            public static Tuple<double, double, double> AnalüüsiArve()
            {
                double[] arvud = Tekstist_arvud();               
                Console.WriteLine("");
                Console.WriteLine("Esimene: " + arvud[0]); 
                Console.WriteLine("Teine: " + arvud[1]);   
                Console.WriteLine("Kolmas: " + arvud[2]);
                palka();




                double summ = arvud[0] + arvud[1] + arvud[2];
                Console.WriteLine($"{arvud[0]} + {arvud[1]} + {arvud[2]} = {summ}");

                Console.WriteLine("");

                double keskmine = arvud[0] + arvud[1] + arvud[2] / 3;
                Console.WriteLine($"{arvud[0]} + {arvud[1]} + {arvud[2]} / 3 = {keskmine}");

                Console.WriteLine("");

                double korrutis = arvud[0] * arvud[1] * arvud[2];
                Console.WriteLine($"{arvud[0]} * {arvud[1]} * {arvud[2]} = {korrutis}");

                Console.WriteLine("");

                Tuple<double, double, double> turple = new Tuple<double, double, double>(summ, keskmine, korrutis);

                Console.WriteLine("");

                palka();
                Console.WriteLine($"summ = {turple.Item1}");

                Console.WriteLine("");

                Console.WriteLine($"keskmine = {turple.Item2}");

                Console.WriteLine("");

                Console.WriteLine($"korrutis = {turple.Item3}");


                return turple;
            }
            public static double[] Tekstist_arvud()
            {
                double[] doubl = new double[3];
                Console.WriteLine($"kirjuta oma 1 arv");
                doubl[0] = double.Parse(Console.ReadLine());
                Console.WriteLine($"kirjuta oma 2 arv");
                doubl[1] = double.Parse(Console.ReadLine());
                Console.WriteLine($"kirjuta oma 3 arv");
                doubl[2] = double.Parse(Console.ReadLine());
                Console.WriteLine("");
                palka();

                return doubl;
            }          

        }

        //3. Nimed ja vanused
        internal class Inimene
        {
            string Nimi; int Vanus;

            public static List<Inimene> inimesedMethod()
            {
                List<Inimene> inimesed = new List<Inimene>();

                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Sisesta nimi: ");
                    string nimi = Console.ReadLine();

                    Console.Write("Sisesta vanus: ");
                    int vanus = int.Parse(Console.ReadLine());

                    Inimene uusIsik = new Inimene();
                    uusIsik.Nimi = nimi;
                    uusIsik.Vanus = vanus;

                    inimesed.Add(uusIsik);
                }          
                return inimesed;
            }

            public static Tuple<int, int, int, int> Statistika(List<Inimene> inimesed)
            {
                List<Inimene> inimesed2 = inimesedMethod();
                int minValue = inimesed2.Min(i => i.Vanus);  //минимальное значенмие vanus в листе с объектами 
                int maxValue = inimesed2.Max(i => i.Vanus);  
                int KogVanuseSumma = 0;
                int keskmineanus = 0;
                for (int i = 0;i <= 5;i++)
                {
                    KogVanuseSumma += inimesed2[i].Vanus;                
                }
                Console.WriteLine($"kogu vanuse summa on {KogVanuseSumma}");
                Console.WriteLine("");

                keskmineanus = KogVanuseSumma / 5;

                Console.WriteLine($"keskmine vanus on {keskmineanus}");
                Console.WriteLine("");

                Console.WriteLine($"kõige noorema inimese vanus on {minValue}");
                Console.WriteLine("");

                Console.WriteLine($"vanima inimese vanus  on {maxValue}");
                Tuple<int, int, int, int> InimesteStatistika = new Tuple<int, int, int, int>(KogVanuseSumma, keskmineanus, minValue ,maxValue);

               return InimesteStatistika;
            }

            
        }

        //4. "Osta elevant ära!"
        public static void KuniMärksõnani()
        {
            List<string> list = new List<string>();
            while (true)
            {
                    Console.OutputEncoding = Encoding.UTF8;
                    int i = 0;       
                    string märksõna;
                    Console.WriteLine($"Osta elevant ara! ({i++})");
                    märksõna = Console.ReadLine();                   
                    list.Add(märksõna);
                    if (märksõna == "Osta elevant ara")
                    {
                        foreach (string n in list)
                        {
                            palka();
                            Console.WriteLine(n);
                        }
                        return;
                    }
                    else
                    {
                        continue;
                    }
                
            }    
        }

        //5. Arvamise mäng
        public static void ArvamiseMäng()
        {
            Random rnd = new Random();
            int arv1 = rnd.Next(1, 100);           

            
                while (true)
                {
                    for (int i = 1; i <= 5; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("kirjuta oma arv");
                        Console.WriteLine("");
                        int arv2 = Convert.ToInt32(Console.ReadLine());
                        if (arv2 > arv1)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("liiga suur");
                            Console.WriteLine("");
                        }
                        else if (arv2 < arv1)
                        {
                            Console.Clear();
                            Console.WriteLine("");
                            Console.WriteLine("liiga väike");
                            Console.WriteLine("");
                        }
                        else if (arv2 == arv1)
                        {
                            Console.Clear();
                            Console.WriteLine("õige");
                            Console.WriteLine("");
                            Console.WriteLine(arv1);
                            return;
                        }
                        
                        if (i  == 5)
                        {
                            Console.Clear();
                            palka();
                            Console.WriteLine("te kaotasite");
                        }
                    }                   
                    Console.WriteLine("Kas mängid veel kord?");
                    Console.WriteLine("1. JAH");
                    Console.WriteLine("2. EI");
                    palka();
                    int veel = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    if (veel == 1)
                    {
                        continue;
                    }
                    else 
                    {
                        return;
                    }
                    
                }
            
            

        }

        //6. Suurim neliarvuline arv
        public static int[] SuurimNeliarvulineArv()
        {
            Console.WriteLine("kirjutage 4 numbrit");
            int[] numbr = new int[4];
            for (int i = 0; i < numbr.Length; i++)
            {
                Console.WriteLine($"kirjutage number {i+1}");
                numbr[i] = Convert.ToInt32(Console.ReadLine());
            }
            return numbr;
        }

        public static void SuurimNeliarv(int[] arvud)
        {
            for (int i = 0; i < arvud.Length; i++)
            {
                if (arvud[i] < 0 || arvud[i] > 9)
                {
                    Console.WriteLine("vale numbrid");
                    return;
                }                                              
            }
            Console.WriteLine($"{arvud[0]}{arvud[1]}{arvud[2]}{arvud[3]}");

        }
        //7. Korrutustabel

        public static Tuple<int, int> TabeliSisestaminee()
        {           
            Console.WriteLine("kirjuta oma ridadeArv");
            int arv1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Kirjuta oma veergudeArv");
            int arv2 = Convert.ToInt32(Console.ReadLine());

            Tuple<int, int> Tuple = new Tuple<int, int>(arv1, arv2);
            return Tuple;
        }


        public static int[,] GenereeriKorrutustabel(int ridadeArv, int veergudeArv) //количествострок и количествостолбцов
        {
            Console.Clear();

            if (ridadeArv <= 0 || veergudeArv <= 0) 
            {
                Console.WriteLine("Arv peab olema suurem kui 0");
                return null;  //возвращает ничего
            }

            int[,] tabel = new int[ridadeArv, veergudeArv];

            for (int r = 0; r < ridadeArv; r++)
            {
                for (int v = 0; v < veergudeArv; v++)
                {
                    tabel[r, v] = (r + 1) * (v + 1);
                    Console.Write(tabel[r, v].ToString().PadLeft(5));
                }
                Console.WriteLine();
            }

            return tabel;
        }

        //8. Õpilastega mängimine

        public static void ÕpilastegaMängimine()
        {
            string[] Nimed = { "Jaan", "Mari", "Tõnu", "Kati", "Andres", "Liis", "Marten", "Anu", "Rasmus", "Heli" };
            int n = 0;
            Nimed[2] = "Kati";
            Nimed[5] = "Mati";

            palka();
            Console.WriteLine(Nimed[2]);

            palka();

            Console.WriteLine(Nimed[5]);

            palka();

            foreach (string nimi1 in Nimed)
            {
                if (nimi1.StartsWith("A"))  //StartsWith - проверяет, начинается ли строка с указанного текста или буквы.
                {
                    Console.WriteLine($"Tere ! {nimi1}");
                }
            }

            palka();

            for (int i = 0; i < Nimed.Length; i++)
            {
                Console.WriteLine($"{Nimed[i]}, index {i}");
            }

            palka();


            foreach (string nimi1 in Nimed)
            {
                Console.WriteLine(nimi1.ToLower());
            }
            palka();

            do
            {
                Console.WriteLine($"Tere! {Nimed[n]}");
                n++;
            }
            while (Nimed[n] != "Mati");
            palka();
        }

        //Arvude ruudud
        public static void ArvudeRuudud()
        {
            int[] arvud = { 2, 4, 6, 8, 10, 12 };
            int ab = 0;
            int count = 0;
            palka();
            for (int i = 0;i < arvud.Length;i++)
            {
                Console.WriteLine($"numbri ruut {arvud[i]} = {arvud[i] = arvud[i] * arvud[i]} ");             
            }
            palka();

            foreach (int arv in arvud)
            {
                Console.WriteLine(arv);
                Console.WriteLine("");
            }
                

            while (ab < arvud.Length )
            {
                if(arvud[ab] % 3 == 0)
                {
                    count++;
                }
                ab++;
            }         
            palka();
            Console.WriteLine($"kõik kordnevad arvud on {count}");
            palka();
        }

        //10 – Positiivsed ja negatiivsed
        public static void PositiivsedJaNegatiivsed()
        {
            int[] arvud = { 5, -3, 0, 8, -1, 4, -7, 2, 0, -5, 6, 9 };
            int positiivseid = 0;
            int negatiivseid = 0;

            foreach (int arv in arvud)
            {
                if (arv >= 0)
                {
                    positiivseid++;
                }
                else
                {
                    negatiivseid++;
                }
            }
            palka();
            Console.WriteLine($"positiivseid arv on {positiivseid}");
            Console.WriteLine("");
            Console.WriteLine($"negatiivseid arv on {negatiivseid}");
            palka();

        }

        //11 – Keskmisest suuremad
        public static void KeskmisestSuuremad()
        {
            Random rnd = new Random();
            int[] masiv = new int[15];
            int summ = 0;
            int ab = 0;

            //random
            for (int i = 0; i < masiv.Length; i++ )
            {
                masiv[i] = rnd.Next(1, 100);
            }
            
            //summ      
            for (int i = 0; i < masiv.Length; i++)
            {
                summ += masiv[i];
            }

            int kesk = summ / masiv.Length;

            palka();
            Console.WriteLine($"keskmine väärtus on võrdne {kesk}");
            palka();

            foreach (int arv in  masiv)
            {
                if (arv > kesk)
                {
                    Console.WriteLine(arv);
                    Console.WriteLine("");
                }
            }
            palka();

            ab = 0; // начинаем с 0
            do
            {
                Console.WriteLine(masiv[ab]);
                Console.WriteLine(""); 

                ab++; 
            }
            while (ab < masiv.Length && masiv[ab] > 10); 
            palka();
        }

        //12 – Kõige suurema arvu otsing
        public static void KõigeSuuremaArvuOtsing()
        {
            int[] numbrid = { 12, 56, 78, 2, 90, 43, 88, 67 };
            int suurim = numbrid[0];

            foreach (int arv in numbrid)
            {
                if (arv > suurim)
                    suurim = arv;
            }

            Console.WriteLine("Suurim arv on: " + suurim);

        }

        //13 – Paari- ja paaritud loendused
        public static void PaariJaPaaritudLoendused()
        {
            Random rnd = new Random();
            List<int> list = new List<int>();
            int PaarituArvudeSumma = 0;
            int kesk = 0;
            int suur = 0;

            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(1, 100));

                if (list[i] % 2 == 0)
                {
                    PaarituArvudeSumma += list[i];
                    kesk++;
                }
            }

            palka();
            Console.WriteLine($"paaritu arvude summa on {PaarituArvudeSumma}");
            palka();

            int keskVV = PaarituArvudeSumma / kesk;
            Console.WriteLine($"Keskmine väärtus on võrdne on {PaarituArvudeSumma} / {kesk} = {keskVV}");
        
            for (int i = 0;i < list.Count; i++)
            {
                if (list[i] > 50)
                {
                    suur++;
                }
            }

            palka();
            Console.WriteLine($"arvude arv on suurem kui 50 võrdub on {suur}");
            palka();
        }


    }
}
