using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KonspektEEE__TAR_.ClassOsa3;

namespace KonspektEEE__TAR_
{
    internal class ClassOsa4    //C# õppematerjal – Failitöötlus ja andmestruktuurid
    {
        public static void StartrProgrammText()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("valige sektsioon");
                Console.WriteLine("(1) Faili kirjutamine ,(2) Ridade lugemine (10) lõpp");
                int txt = int.Parse(Console.ReadLine());
                switch (txt)
                {
                    case 1:
                        SaveText();
                        break;
                    case 2:
 
                        break;
                    case 3:
                        Console.WriteLine("faili nimi");
                        string fail = Console.ReadLine();
                        Ridade_lugemine_listiks(fail);
                        break;
                    case 4:

 
                        break;
                    case 10:
                        return;                    
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("korda valik");
                        break;
                }
            }
        }
        public static void SaveText()
        {
            //🧾 Faili kirjutamine (StreamWriter)
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Kuud.txt"); //@"..\..\..\Kuud.txt"
                StreamWriter text = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("Sisesta mingi tekst: ");
                string lause = Console.ReadLine();
                text.WriteLine(lause);
                text.Close();

            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }
        public static  List<string> Ridade_lugemine_listiks(string fail)
        {
            List<string> kuude_list = new List<string>();
            try
            {
                string path = @$"..\..\..\{fail}";
                foreach (string rida in File.ReadAllLines(path))
                {
                    kuude_list.Add(rida);
                }
                foreach(string i in kuude_list)
                {
                    Console.WriteLine(i);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Viga failiga!");
            }
            return kuude_list;
        }

        public static void ListiMuutmineJaKuvamine(List<string> kuude_list)
        {
            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }

            // Eemalda "Juuni"
            kuude_list.Remove("Juuni");

            // Muuda esimest elementi
            if (kuude_list.Count > 0)
                kuude_list[0] = "Veeel kuuu";

            Console.WriteLine("--------------Kustutasime juuni-----------");

            foreach (string kuu in kuude_list)
            {
                Console.WriteLine(kuu);
            }
        }


    }
}
