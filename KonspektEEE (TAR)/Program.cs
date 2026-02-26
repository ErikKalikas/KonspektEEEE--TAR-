using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;
using KonspektEEE__TAR_;
using static KonspektEEE__TAR_.ClassOsa3;

namespace Naidis_IKTpv25
{
    public class startPage
    {              
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("valige osa");
                Console.WriteLine("1");
                Console.WriteLine("2");
                Console.WriteLine("3");
                Console.WriteLine("6 - exit");
                Console.WriteLine("------------------------------");
                int osa = int.Parse(Console.ReadLine());
                Console.Clear();
                if (osa == 1)
                {
                    ClassOsa1.osa1();
                }
                else if (osa == 2)
                {
                    ClassOsa2.Ülesandeid();
                }
                else if (osa == 3)
                {
                    Console.WriteLine("valige sektsioon");
                    Console.WriteLine("1-13, (14)konspek ja (15)Teoria");
                    int valik = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (valik)
                    {
                        case 1:
                            ArvuTöötlus.GenereeriRuudud();
                            break;
                        case 2:
                            ArvuTöötlus.AnalüüsiArve();
                            break;
                        case 3:
                            List<Inimene> inimesed = Inimene.inimesedMethod();
                            Tuple<int, int, int, int> stat = Inimene.Statistika(inimesed);
                            break;
                        case 4:
                            KuniMärksõnani();
                            break;
                        case 5:
                            ArvamiseMäng();
                            break;
                        case 6:
                            int[] arvud = ClassOsa3.SuurimNeliarvulineArv();
                            ClassOsa3.SuurimNeliarv(arvud);
                            break;
                        case 7:
                            var suurused = ClassOsa3.TabeliSisestaminee();
                            ClassOsa3.GenereeriKorrutustabel(suurused.Item1, suurused.Item2);
                            break;
                        case 8:
                            ÕpilastegaMängimine();
                            break;
                        case 9:
                            ArvudeRuudud();
                            break;
                        case 10:
                            PositiivsedJaNegatiivsed();
                            break;
                        case 11:
                            KeskmisestSuuremad();
                            break;
                        case 12:
                            KõigeSuuremaArvuOtsing();
                            break;
                        case 13:
                            PaariJaPaaritudLoendused();
                            break;
                        case 14:
                            konspekt();
                            break;
                        case 15:
                            Teoria();
                            break;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("korda valik");
                            break;

                    }
                }
                else if (osa == 6)
                {
                    return;
                }
                else
                {
                    Console.WriteLine("");
                    Console.WriteLine("korda valik");
                    continue;
                }
            }



            PaariJaPaaritudLoendused();

            //KõigeSuuremaArvuOtsing();

            //KeskmisestSuuremad();

            //PositiivsedJaNegatiivsed();

            //ArvudeRuudud();

            //ÕpilastegaMängimine();

            //var t = ClassOsa3.TabeliSisestaminee();
            //ClassOsa3.GenereeriKorrutustabel(t.Item1, t.Item2);

            //ClassOsa3.SuurimNeliarv(ClassOsa3.SuurimNeliarvulineArv());

            //ArvuTöötlus.AnalüüsiArve();

            //ArvuTöötlus.GenereeriRuudud();

            //ClassOsa3.konspekt();

            //ClassOsa1.osa1();

            //ClassOsa3.Teoria();







        }



    }
}