using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace KonspektEEE__TAR_
{
    internal class Naidis_fnktsion
    {
        public static float Summa(float arv1, float arv2)
        {
            return arv1 + arv2;
        }
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

        //Ülesandeid:

        public static void Juku(string nimi1)
        {
            Console.WriteLine("mis on sinu nimi?");
            string nimi = Console.ReadLine();

            if (nimi == "Juku")
            {
                nimi1 += nimi;
                Console.WriteLine("kirjuta oma sinu nimi");
                int vanus = Convert.ToInt32(Console.ReadLine());
                while (true)
                {
                    if (vanus < 6)
                    {
                        continue;
                    }
                    else if (vanus == 6)
                    {
                        Console.WriteLine("pilet on tasuta");
                        break;
                    }
                    else if (vanus >= 7 && vanus <= 14)
                    {
                        Console.WriteLine("lastepilet");
                        break;
                    }
                    else if (vanus >= 15 && vanus <= 65)
                    {
                        Console.WriteLine("täispilet");
                    }
                }
            }
            else { }

        }

        public static void Ülesandeid()
        {
            Console.WriteLine("kuidas on sinu nimi?");
            string nimi = Console.ReadLine(); 
            Console.WriteLine("kuidas on kahe inimese nimed?");
            string nimi2 = Console.ReadLine();
            Console.WriteLine($"{nimi} ja {nimi2} istuvad koos");

            Console.WriteLine("kirjutage ristkülikukujulise toa seinte pikkus");
            int arv1 = int.Parse(Console.ReadLine());

            Console.WriteLine("kirjutage ristkülikukujulise toa seinte laius");
            int arv2 = int.Parse(Console.ReadLine());
            int pindala = arv1 * arv2;

            Console.WriteLine($"põranda pindala on võrdne = {pindala}");


            while (true)
            {
                Console.WriteLine("Kas soovite remontida?");
                Console.WriteLine("JAH/EI");
                string chose = Console.ReadLine();
                if (string.Equals(chose, "jah", StringComparison.OrdinalIgnoreCase)) //игнорирование регистра
                {
                    Console.WriteLine("Kui palju maksab ruutmeetri hind?");
                    int hind = int.Parse(Console.ReadLine());

                    int koguhind = pindala * hind;
                    double result = koguhind * 0.70;

                    Console.WriteLine($"remondi maksumus on {result}€");
                    break;

                }
                else if (string.Equals(chose, "ei", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("sisestage jah või ei");
                    return;
                }
            }

            Console.WriteLine("Mis temperatuur on teie toas?");
            int temperatuur = int.Parse(Console.ReadLine());
            if (temperatuur > 18)
            {
                Console.WriteLine("Teie toa temperatuur ületab talvel soovitatavat temperatuuri 18 kraadi.");
            }

            Console.WriteLine("kirjuta oma pikkust");
            int pikkust = Convert.ToInt32(Console.ReadLine());
            if (pikkust <= 0)
            {
                Console.WriteLine("võimatu pikkus");
            }
            else if (pikkust == 1)
            {
                Console.WriteLine("juntsu");
            }
            else if (pikkust == 2)
            {
                Console.WriteLine("tavaline kolge");
            }
            else if (pikkust > 2)
            {
                Console.WriteLine("hiiglane");
            }
            Console.WriteLine("kirjutage oma sugu");
            string sugu = Console.ReadLine();


            int piim = 3;
            int sai = 2;
            int leib = 3;
            int result2 = 0;
            while (true)
            {
                Console.WriteLine("Kas soovite osta eraldi piima, saiu ja leiba?");
                Console.WriteLine("JAH/EI");
                string chose2 = Console.ReadLine();

                if (string.Equals(chose2, "jah", StringComparison.OrdinalIgnoreCase)) //игнорирование регистра
                {
                    result2 = piim + sai + leib;
                    Console.WriteLine($"{result2}€");
                    break;
                }
                else if (string.Equals(chose2, "ei", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"{piim}€");
                    Console.WriteLine($"{sai}€");
                    Console.WriteLine($"{leib}€");
                    break;
                }
                else
                {
                    Console.WriteLine("sisestage jah või ei");
                    return;
                }
            }
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
    }
}
