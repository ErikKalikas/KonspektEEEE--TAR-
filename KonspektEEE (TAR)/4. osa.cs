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
                try
                {
                    Console.Clear();
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("valige ülesanne");
                    Console.WriteLine("1");
                    Console.WriteLine("2");
                    Console.WriteLine("3");
                    Console.WriteLine("4");
                    Console.WriteLine("5");
                    Console.WriteLine("6");
                    Console.WriteLine("7");
                    Console.WriteLine("8");
                    Console.WriteLine("9");
                    Console.WriteLine("10 - lõpp");
                    Console.WriteLine("------------------------------");
                    Console.WriteLine("");
                    int txt = int.Parse(Console.ReadLine());
                    Console.Clear();
                    switch (txt)
                    {
                        case 1:
                            Ülesanne1();
                            break;
                        case 2:
                            Ülesanne2();
                            break;
                        case 3:
                            Ülesanne3();
                            break;
                        case 4:
                            Ülesanne4(Ülesanne3());
                            break;
                        case 10:
                            return;
                        default:
                            Console.WriteLine("");
                            Console.WriteLine("korda valik");
                            break;
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
       
        public static void Ülesanne1()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt"); //@"..\..\..\Kuud.txt"
                StreamWriter file = new StreamWriter(path, true); // true = lisa lõppu
                Console.WriteLine("what you favourite italian dish");
                string lause = Console.ReadLine();
                file.WriteLine(lause);
                file.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga");
            }
        }

        public static void Ülesanne2()
        {
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Retseptid.txt");
                StreamReader file = new StreamReader(path);
                string laused = file.ReadToEnd();
                file.Close();
                Console.WriteLine(laused);
            }
            catch (Exception)
            {
                Console.WriteLine("Mingi viga failiga, ei saa faili lugeda");
            }

        }

        public static List<string> Ülesanne3()
        {
            List<string> ingridientList = new List<string>();
            try
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Koostisosad.txt");
                foreach (string rida in File.ReadAllLines(path))
                {
                    //if (rida != "ketchup")
                    //{
                        ingridientList.Add(rida);
                   // }                  
                }
                //if (ingridientList.Contains("ketchup"))
                //{
                    ingridientList.Remove("ketchup");
                //}

                StreamWriter ffile = new StreamWriter(path, true);

                ingridientList[0] = "Kvaliteetne oliiviõli";
                Console.WriteLine($"1. {ingridientList[0]}");

                foreach (string retsept in ingridientList)
                {
                    ffile.WriteLine(retsept);
                    Console.WriteLine(retsept);
                }
                ffile.Close();
            }
            catch (Exception)
            {
                Console.WriteLine("Viga!");
            }
            
            return ingridientList;
        }

        public static void Ülesanne4(List<string> ingridientList)
        {
            try
            {
                Console.WriteLine("kirjuta oma product");
                string otsitav = Console.ReadLine();
            }
            catch (Exception)
            {
                Console.WriteLine("viga");
            }
        }
    }
}
