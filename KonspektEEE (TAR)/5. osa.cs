using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace KonspektEEE__TAR_
{
    class Person //3
    {
        public string Name { get; set; }
    }
    class Toode //Ülesanne 1
    {
        public string Nimi { get; set; }
        public int kal100 { get; set; }
    }
    class Inimene //Ülesanne 1
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public int Sugu { get; set; }
        public int Pikkus { get; set; }
        public int Kaal { get; set; }
        public int Aktiivsustase { get; set; } 

        public Inimene(string Nimi, int Vanus, int Sugu, int Pikkus, int kaal, int Aktiivsustase)
        {
            this.Nimi = Nimi;
            this.Vanus = Vanus;
            this.Sugu = Sugu;
            this.Pikkus = Pikkus;
            this.Kaal = kaal;
            this.Aktiivsustase = Aktiivsustase;
        }
    }
    
    class Õpilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }
    }

    internal class ClassOsa5
    {
        public static void startOsa5()
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
                    Console.WriteLine("7 - teoria");
                    Console.WriteLine("8 - lõpp");
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

                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:
                            teoria();
                            break;
                        case 8:
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
        public static void teoria()
        {
            //1. ArrayList (System.Collections)


            //ArrayList — это простой способ сбора данных, размер которого не нужно задавать заранее. Он автоматически адаптируется к количеству добавляемых элементов. 
            ArrayList test = new ArrayList();

            //Add() – добавляет элемент в конец списка
            test.Add("test1");
            test.Add("test2");
            test.Add("test3");

            //Contains() – проверяет наличие элемента
            if (test.Contains("test2"))
            {
                Console.WriteLine("test2 olemas");
            }

            //Count – возвращает количество элементов
            Console.WriteLine(test.Count);

            //Insert(index, item) – добавляет элемент в указанное место
            test.Insert(3, "test4");

            //IndexOf() – ищет индекс элемента
            test.IndexOf(0);

            //Sort() – сортирует элементы по возрастанию
            Console.WriteLine();



            //Näide:
            ArrayList nimed = new ArrayList();
            nimed.Add("Kati");
            nimed.Add("Mati");
            nimed.Add("Juku");

            if (nimed.Contains("Mati"))
            {
                Console.WriteLine("Mati olemas");
            }
                

            Console.WriteLine("Nimesid kokku: " + nimed.Count);

            nimed.Insert(1, "Sass");

            Console.WriteLine("Mati indeks: " + nimed.IndexOf("Mati"));
            Console.WriteLine("Mari indeks: " + nimed.IndexOf("Mari"));

            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }



            //2. Tuple (järjendid)
            //turple — это структура данных фиксированного размера и фиксированного типа, элементы которой могут быть разных типов.

            //Näide:
            Tuple<float, char> route = new Tuple<float, char>(2.5f, 'N');
            Console.WriteLine($"Vahemaa: {route.Item1}, Suund: {route.Item2}");



            //3. List (System.Collections.Generic)
            //Набор типов с сильной типизацией. Наиболее часто используемый тип данных в повседневной разработке.


            //Add(item) — добавляет один элемент item в конец списка.
            test.Add("test5");

            //AddRange(collection) — добавляет несколько элементов из коллекции collection в конец списка.
            Collection<string> TestCollection = new Collection<string> {"test6", "test7" };
            test.AddRange(TestCollection);

            //IndexOf(item) — возвращает индекс первого найденного элемента item в списке (или -1, если элемент не найден).

            //Remove(item) — удаляет первый найденный элемент item из списка.                        
            List<Person> people = new List<Person>();                                                                           
            people.Add(new Person() { Name = "Kadi" });
            people.Add(new Person() { Name = "Mirje" });

            Person lisa = new Person() { Name = "Lisa" };
            people.Remove(lisa);

            //RemoveAt(index) — удаляет элемент по указанному индексу index.
            List<string> test2 = new List<string>();
            test2.Add("Kadi");
            test2.Add("Mati");
            test2.RemoveAt(1);
            //Insert(index, item) — добавляет элемент item на указанную позицию index в списке.
            test.Insert(1, "johan");

            //Sort() — сортирует элементы списка по возрастанию.
            List<string> names = new List<string>();
            names.Add("Kadi");
            names.Add("Mati");
            names.Add("johan");

            names.Sort();

            //BinarySearch(item) — выполняет быстрый поиск элемента item в отсортированном списке и возвращает его индекс (если не найден — возвращает отрицательное число).
            int index = names.BinarySearch("Mati");

            Console.WriteLine(index);

            //Näide:


            List<Person> people2 = new List<Person>();
              people2.Add(new Person() { Name = "Kadi" });
              people2.Add(new Person() { Name = "Mirje" });

              foreach (Person p in people)
              Console.WriteLine(p.Name);



            //4. LinkedList (System.Collections.Generic)
            //Структура данных, организованная в виде списка. Хорошо подходит, если часто требуется добавлять или удалять элементы в начале или в середине списка.
            LinkedList<string> test3 = new LinkedList<string>();

            //AddFirst(value) — добавляет элемент value в начало LinkedList.
            test3.AddFirst("100");

            //AddLast(value) — добавляет элемент value в конец LinkedList.
            test3.AddLast("102");

            //AddBefore(node, value) — добавляет элемент value перед указанным узлом node в LinkedList.
            LinkedListNode<string> node = test3.Find("102");
            test3.AddBefore(node, "101"); // список: 100, 101, 102

            //AddAfter(node, value) — добавляет элемент value после указанного узла node в LinkedList.
            test3.AddAfter(node, "103");  // список: 100, 101, 102, 103

            //RemoveFirst() — удаляет первый элемент из LinkedList.
            test3.RemoveFirst(); // список: 101, 102, 103

            //RemoveLast() — удаляет последний элемент из LinkedList.
            test3.RemoveLast();  // список: 101, 102

            //Remove(value) — удаляет первый найденный элемент со значением value из LinkedList.
            test3.Remove("101"); // список: 102

            //вывод
            foreach (var item in test3)
            {
                Console.WriteLine(item);
            }


            //Näide:
            LinkedList<int> loetelu = new LinkedList<int>();
                 loetelu.AddLast(5);
                 loetelu.AddLast(3);
                 loetelu.AddFirst(0);

                    foreach (int arv in loetelu)
                    {
                        Console.WriteLine(arv);
                    }
                      
                 loetelu.RemoveFirst();
                 loetelu.RemoveLast();
                 loetelu.AddLast(555);
                 loetelu.Remove(555);



            //5. Dictionary<TKey, TValue> – Sõnastik
            //Словарь (dictionary) позволяет хранить пары «ключ-значение». Быстрый поиск и удобная структура, когда нужно описать взаимосвязи (например, ID и имя, страна и столица).
            Dictionary<int, string> test4 = new Dictionary<int, string>();

            //Add(key, value) — добавляет пару ключ-значение (key — ключ, value — значение) в Dictionary.
            test4.Add(1, "pepsi");
            test4.Add(2, "kola");
            test4.Add(3, "lipton");

            //Remove(key) — удаляет элемент из Dictionary по указанному ключу key.
            test4.Remove(2);

            //ContainsKey(key) — проверяет, существует ли указанный ключ key в Dictionary (возвращает true или false).
            Console.WriteLine(test4.ContainsKey(2));

            //ContainsValue(value) — проверяет, есть ли в Dictionary указанное значение value.
            Console.WriteLine(test4.ContainsValue("lipton"));

            //Keys — возвращает коллекцию всех ключей в Dictionary.
            foreach (var key in test4.Keys)
            {
                Console.WriteLine(key);
            }

            //Values — возвращает коллекцию всех значений в Dictionary.
            foreach (var value in test4.Values)
            {
                Console.WriteLine(value);
            }


            //Näide:
            Dictionary<int, string> riigid = new Dictionary<int, string>();
            riigid.Add(1, "Hiina");
            riigid.Add(2, "Eesti");
            riigid.Add(3, "Itaalia");

            foreach (var paar in riigid)
            {
                Console.WriteLine($"{paar.Key} - {paar.Value}");
            }
                

            string pealinn = riigid[2];
            riigid[2] = "Eestimaa";
            riigid.Remove(3);

            //Klasside näide:

            Dictionary<char, Person> inimesed = new Dictionary<char, Person>();
            inimesed.Add('k', new Person() { Name = "Kadi" });
            inimesed.Add('m', new Person() { Name = "Mait" });

            foreach (var entry in inimesed)
            {
                Console.WriteLine($"{entry.Key} - {entry.Value.Name}");
            }
                
        }


        //-------------------------------------------------

        public static void Ülesanne1() //1
        {
            //toit
            List<Toode> tooted = new List<Toode>()
            {
                new Toode { Nimi = "Õun",  kal100 = 52 },
                new Toode { Nimi = "Leib", kal100 = 250 },
                new Toode { Nimi = "Kana", kal100 = 165 },
                new Toode { Nimi = "Riis", kal100 = 130 }
            };

            int valik;
            int kaal;
            string toote;
            string nimi1;
            int vanus;
            int sugu;
            int Pikkus;
            int aktiivsused;
            while (true)
            {
                try
                {
                    visual.palka();
                    Console.WriteLine("Kas te olete mees? (1 - jah, 2 - ei)");
                    visual.palka();
                    sugu = int.Parse(Console.ReadLine());
                    Console.Clear();
                    if (sugu != 1 && sugu != 2)
                    {
                        continue;
                    }
                    


                    visual.palka();
                    Console.WriteLine("kuidas sinu nimi?");
                    visual.palka();
                    nimi1 = Console.ReadLine();
                    Console.Clear();

                    visual.palka();
                    Console.WriteLine("Kui vana sa oled?");
                    visual.palka();
                    vanus = int.Parse(Console.ReadLine());
                    Console.Clear();

                    visual.palka();
                    Console.WriteLine("Kui pikk sa oled? cm");
                    visual.palka();
                    Pikkus = int.Parse(Console.ReadLine());
                    Console.Clear();

                    visual.palka();
                    Console.WriteLine("Kui palju sa kaalud? (kg):");
                    visual.palka();
                    kaal = int.Parse(Console.ReadLine());
                    Console.Clear();

                    visual.palka();
                    Console.WriteLine("Milline on sinu aktiivsusaste? (1. väike, 2. normaalne, 3. suur)");
                    visual.palka();
                    aktiivsused = int.Parse(Console.ReadLine());
                    Console.Clear();
                    break;
                }
                catch (Exception)
                {
                    continue;
                }                
            }
            Inimene inimene = new Inimene(nimi1, vanus, sugu, Pikkus, kaal, aktiivsused);



            //Harris-Benedict valem

            double bmr;

            if (inimene.Sugu == 1)
            {
                bmr = 88.36 + (13.4 * inimene.Kaal) + (4.8 * inimene.Pikkus) - (5.7 * inimene.Vanus);
            }
            else
            {
                bmr = 447.6 + (9.2 * inimene.Kaal) + (3.1 * inimene.Pikkus) - (4.3 * inimene.Vanus);
            }




            //aktivsus

            double kordaja = 1.2;

            if (inimene.Aktiivsustase == 2) 
            {
                kordaja = 1.55; 
            }
            else if (inimene.Aktiivsustase == 3)
            {
                kordaja = 1.9;
            }

            double paevasedKalorid = bmr * kordaja;
            
            Console.WriteLine($"\nSinu päevane kalorivajadus: {paevasedKalorid} kcal\n");
            



            //Toidusoovitused
            
            Console.WriteLine("Kui palju võid süüa päevas:");
            Console.WriteLine("");
            
            foreach (var toode in tooted)
            {
                double grammid = (paevasedKalorid / toode.kal100) * 100;
                Console.WriteLine($"{toode.Nimi}: {grammid:F0} g");
            }
        }

        public static void Ülesanne2() //2
        {
            Dictionary<string, string> goroda = new Dictionary<string, string>();
            string valik = "";
            int valik2 = 0;
            int valik3 = 0;
            int globalvalik = 0;
            bool save;
            string novigorod = "";
            string noviokrug = "";

            goroda.Add("Harjumaa", "Tallinn");
            goroda.Add("Tartumaa", "Tartu");
            goroda.Add("Ida-Virumaa", "Narva");
            goroda.Add("Pärnumaa", "Pärnu");
            goroda.Add("Viljandimaa", "Viljandi");
            goroda.Add("Saaremaa", "Kuressaare");
            goroda.Add("Lääne-Virumaa", "Rakvere");
            goroda.Add("Võrumaa", "Võru");
            goroda.Add("Valgamaa", "Valga");

            //Console.WriteLine(goroda["Harjumaa"]);
            //goroda.TryGetValue("Harjumaa", out string city);
            while (true)
            {
                try
                {
                    visual.palka();
                    Console.WriteLine("1. kontrollimine ja täitmine ");
                    Console.WriteLine("2. mäng");
                    Console.WriteLine("3. näita kõiki linnu ja valdasid");
                    Console.WriteLine("4. lõpp");
                    visual.palka();
                    globalvalik = int.Parse(Console.ReadLine());
                    Console.Clear();
                }
                catch (Exception)
                {                    
                    continue;
                }               
                if (globalvalik == 1)
                {
                    while (true)
                    {

                        try
                        {
                            visual.palka();
                            Console.WriteLine("valige maakond");
                            visual.palka();


                            valik = Console.ReadLine();
                            Console.Clear();
                        }
                        catch (Exception)
                        {
                            continue;
                        }

                            save = goroda.ContainsKey(valik);
                            if (save == true)
                            {
                                visual.palka();
                                Console.WriteLine($"valik, {goroda[valik]}");
                                visual.palka();

                                Console.Clear();
                                try
                                {
                                    visual.palka();
                                    Console.WriteLine("Kas soovite seda korrata? (1. JAH/ 2. EI)");
                                    visual.palka();
                                    valik3 = int.Parse(Console.ReadLine());

                                    Console.Clear();
                                }
                                catch (Exception)
                                {
                                    continue;
                                }
                                    if (valik3 == 1)
                                    {
                                        continue;
                                    }
                                    if (valik3 == 2)
                                    {
                                        break;
                                    }
                                    else
                                    {
                                        visual.palka();
                                        Console.WriteLine("proovige uuesti");
                                        continue;
                                    }
                            }
                            else
                            {
                                Console.WriteLine("Sellist ringkonda pole. Kas soovite lisada uue ringkonna ja selle pealinna? (1. JAH/ 2. EI)");
                                valik2 = int.Parse(Console.ReadLine());
                                if (valik2 == 1)
                                {
                                    Console.WriteLine("sisestage uus piirkond");
                                    noviokrug = Console.ReadLine();

                                    Console.WriteLine("sisestage uus linn, mis on maakonna keskus");
                                    novigorod = Console.ReadLine();

                                    goroda.Add(novigorod, novigorod);
                                    Console.WriteLine("Uus piirkond ja uus linn on lisatud!");
                                    break;
                                }
                                else if (valik2 == 2)
                                {
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("proovige uuesti");
                                    continue;
                                }
                            }
                       
                    }
                }
                else if (globalvalik == 2)
                {
                    while (true)
                    {
                        int õiged = 0;
                        List<string> okrug2 = goroda.Keys.ToList();
                        List<string> gorod2 = goroda.Values.ToList();
                        

                        Random rnd = new Random();
                        string randomGorod = gorod2[rnd.Next(gorod2.Count)];
                        visual.palka();
                        Console.WriteLine("kirjuta, millisesse ringkonda see linn kuulub");
                        visual.palka();
                        Console.WriteLine(randomGorod);

                        string vastus = Console.ReadLine();
                        Console.Clear();

                        string õigemaakond = "";

                        foreach (var pair in goroda)
                        {
                            if (pair.Value == randomGorod)
                            {
                                õigemaakond = pair.Key;
                                break;
                            }
                        }

                        if (vastus.ToLower() == õigemaakond.ToLower())
                        {
                            visual.palka();
                            Console.WriteLine("Õige");
                            visual.palka();
                            õiged++;
                        }
                        else
                        {
                            Console.WriteLine($"Vale. Õige vastus: {õigemaakond}");
                        }

                        Console.WriteLine("Kas soovite seda korrata? (1. JAH/ 2. EI)");
                        visual.palka();
                        valik3 = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (valik3 == 1)
                        {
                            continue;
                        }
                        if (valik3 == 2)
                        {
                            break;
                        }
                        else
                        {
                            visual.palka();
                            Console.WriteLine("proovige uuesti");
                            continue;
                        }
                    }                    
                }
                else if (globalvalik == 3)
                {
                    foreach (var item in goroda)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Kas soovite seda korrata? (1. JAH/ 2. EI)");
                    visual.palka();
                    valik3 = int.Parse(Console.ReadLine());

                    Console.Clear();
                    if (valik3 == 1)
                    {
                        continue;
                    }
                    if (valik3 == 2)
                    {
                        break;
                    }
                    else
                    {
                        visual.palka();
                        Console.WriteLine("proovige uuesti");
                        continue;
                    }
                }
                else if (globalvalik == 4)
                {
                    break;
                }
                else
                {
                    continue;
                }
            }

                

        }

        public static void Ülesanne3() //3
        {
            List<Õpilane> õpilane2 = new List<Õpilane>()
            {
                new Õpilane { Nimi = "Maksim", Hinded = new List<int> { 3, 3, 3 } },
                new Õpilane { Nimi = "Nikita", Hinded = new List<int> { 5, 3, 4 } },
                new Õpilane { Nimi = "Johan", Hinded = new List<int> { 5, 5, 5 } }
            };

            Dictionary<string, double> keskhind = new Dictionary<string, double>();

            Console.WriteLine("Õpilaste keskmised hinded:");
            foreach (var o in õpilane2)
            {
                keskhind.Add(o.Nimi, o.Hinded.Average());
                Console.WriteLine($"{o.Nimi}: {keskhind[o.Nimi]}");
            }

            
            
        }

    }
}
