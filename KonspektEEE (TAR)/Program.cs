using KonspektEEE__TAR_;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Naidis_IKTpv25
{
    public class startPage
    {
        public static string Kuu_nimetus(int kuu_nr)
        {
            string kuu = "";
            switch (kuu_nr)
            {
                case 1: kuu = "Jaanuar"; break;
                case 2: kuu = "Veebruar"; break;
                case 3: kuu = "Märts"; break;
                case 4: kuu = "Aprill"; break;
                case 5: kuu = "Mai"; break;
                case 6: kuu = "Juuni"; break;
                case 7: kuu = "Juuli"; break;
                case 8: kuu = "August"; break;
                case 9: kuu = "September"; break;
                case 10: kuu = "Oktoober"; break;
                case 11: kuu = "Novemberr"; break;
                case 12: kuu = "Detsember"; break;

                default:
                    kuu = "???";
                    break;
            }
            return kuu;
        }

        public static string Hooaeg(int kuu_nr)
        {
            string hoo = "";
            if (kuu_nr == 1 || kuu_nr == 2 || kuu_nr == 12) //&& - and, || - or
            {
                hoo = "Talv";
            }
            else if (kuu_nr > 2 && kuu_nr < 6)
            {
                hoo = "Kevad";
            }
            else if (kuu_nr > 5 && kuu_nr < 9)
            {
                hoo = "Suvi";
            }
            else if (kuu_nr > 8 && kuu_nr < 12) //9,10,11
            {
                hoo = "Sügis";
            }
            else
            {
                hoo = "???";
            }
            return hoo;
        }

        public static void Main(string[] args)
        {
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("1. Osa Andmetüübid");
            string tekst = "wew";
            //Console.WriteLine($"-> {tekst}");
            //Console.WriteLine($"-> {0}", tekst);

            //Console.Write("mis on sine nimi ");
            //string nimi = Console.ReadLine();
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("kui vana sa oled?: ");
            //        int vanus = int.Parse(Console.ReadLine());
            //        Console.WriteLine($"tere {nimi}. Sa olded {vanus} aastat vana");
            //        break;
            //    }
            //    catch (Exception e)
            //    {
            //        continue;

            //    }
            //}
            //try
            //{
            //    Console.WriteLine("Arv 1:");
            //    float a = float.Parse(Console.ReadLine());
            //    Console.WriteLine("Arv 2 :");
            //    float b = float.Parse(Console.ReadLine());
            //    float vastus = Naidis_fnktsion.Summa(a, b);
            //    Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            //}
            //catch (Exception e)
            //{

            //    Console.WriteLine(e);
            //}

            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            Console.WriteLine(Naidis_fnktsion.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            tekst = Naidis_fnktsion.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(tekst);

        }

        
    }
}