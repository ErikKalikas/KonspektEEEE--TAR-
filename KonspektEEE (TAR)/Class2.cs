using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    internal class Osa2_funktsioonid
    {

        public static void Juku(string nimi1 )
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
                    else if (vanus >= 15 && vanus <=65)
                    {
                        Console.WriteLine("täispilet");
                    }
                }
            }
            else { }
            
        }
    }
}
