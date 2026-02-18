using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    internal class ClassOsa3
    {
        public static void Masivvv()
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

            int[] uusMasiv = ClassOsa3.masiv1();


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
