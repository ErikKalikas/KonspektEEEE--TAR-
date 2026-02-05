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


        }
        
    }
}