using KonspektEEE__TAR_;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace Naidis_IKTpv25
{
    public class startPage
    {              
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("1. Osa Andmetüübid");
            string tekst = "wew";
            Console.WriteLine($"-> {tekst}");
            Console.WriteLine($"-> {0}", tekst);

            Console.Write("mis on sine nimi ");
            string nimi = Console.ReadLine();
            while (true)
            {
                try
                {
                    Console.WriteLine("kui vana sa oled?: ");
                    int vanus = int.Parse(Console.ReadLine());
                    Console.WriteLine($"tere {nimi}. Sa olded {vanus} aastat vana");
                    break;
                }
                catch (Exception e)
                {
                    continue;

                }
            }
            try
            {
                Console.WriteLine("Arv 1:");
                float a = float.Parse(Console.ReadLine());
                Console.WriteLine("Arv 2 :");
                float b = float.Parse(Console.ReadLine());
                float vastus = Naidis_fnktsion.Summa(a, b);
                Console.WriteLine($"Summa {a} ja {b} võrdub {vastus}");
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
            }

            Random rnd = new Random();
            int juhuslik_arv = rnd.Next(-5, 25);
            Console.WriteLine(Naidis_fnktsion.Kuu_nimetus(juhuslik_arv));
            juhuslik_arv = rnd.Next(-5, 25);
            tekst = Naidis_fnktsion.Kuu_nimetus(juhuslik_arv);
            Console.WriteLine(tekst);

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



    }
}