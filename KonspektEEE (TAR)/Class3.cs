using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    public class Isisk
    {
        public string Nimi;
        public int Vanus;
        
            public Isisk(string nimi, int vanus)
            {
            Nimi = nimi;
            Vanus = vanus;
            }

            public Isisk()
            {
                
            }
            
            public void Tervita()
            {
                Console.WriteLine();
            }


        //static void Main()
        //{
        //    List<Isik> inimesed = new List<Isik>();

        //    for (int i = 0; i < 3; i++)
        //    {
        //        Console.Write("Sisesta nimi: ");
        //        string nimi = Console.ReadLine();

        //        Console.Write("Sisesta vanus: ");
        //        int vanus = int.Parse(Console.ReadLine());

        //        Isik uusIsik = new Isik();
        //        uusIsik.Nimi = nimi;
        //        uusIsik.Vanus = vanus;

        //        inimesed.Add(uusIsik);
        //    }

        //    Console.WriteLine("\nKõik inimesed tervitavad:\n");

        //    foreach (Isik isik in inimesed)
        //    {
        //        isik.Tervita();
        //    }
        //}
    }
}
