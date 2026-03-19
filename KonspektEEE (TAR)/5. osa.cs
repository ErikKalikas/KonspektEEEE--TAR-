using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        public string Sugu { get; set; }
        public double Pikkus { get; set; }
        public double Kaal { get; set; }
        public string Aktiivsustase { get; set; } 

        public Inimene(string Nimi, int Vanus, string Sugu, double Pikkus, double kaal, string Aktiivsustase)
        {
            this.Nimi = Nimi;
            this.Vanus = Vanus;
            this.Sugu = Sugu;
            this.Pikkus = Pikkus;
            this.Kaal = kaal;
            this.Aktiivsustase = Aktiivsustase;
        }
    }

    internal class ClassOsa5
    {
        public static void startOsa5()
        {
            while (true)
            {
                try
                {
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
            Inimene H1 = new Inimene();




            List<Inimene> inimene1 = new List<Inimene>();
            List<Toode> Toode1 = new List<Toode>();
            string jahei = "";
            bool mees;
            while (true)
            {
                try
                {
                    Console.WriteLine("Kas te olete mees? (jah/ei)");
                    jahei = Console.ReadLine();
                    Console.Clear();                    
                    if (jahei == "jah")
                    {
                        mees = true;
                        break;
                    }
                    else if (jahei == "ei")
                    {
                        mees = false;
                        break;
                    }
                }
                catch (Exception)
                {                   
                    continue;
                }
            }
            
                
            


            Console.WriteLine("kirjutage toote nimi");
            string toote = Console.ReadLine();




            Console.WriteLine("kuidas sinu nimi?");
            string nimi = Console.ReadLine();


            Console.WriteLine("Kui vana sa oled?");
            int vanus = int.Parse(Console.ReadLine());


            Console.WriteLine("Milline on su sugu?");
            string sugu = Console.ReadLine();


            Console.WriteLine("Kui pikk sa oled? (arv.arv)m");
            char Pikkus = char.Parse(Console.ReadLine());


            Console.WriteLine("Milline on sinu aktiivsusaste? (1. väike, 2. normaalne, 3. suur)");
            int aktiivsused = int.Parse(Console.ReadLine());
            string aktiivsused2 = "";
            while (true)
            {
                try
                {
                   if (aktiivsused == 1)
                   {
                        aktiivsused2 = "väike";
                   }
                   else if (aktiivsused == 2)
                   {
                        aktiivsused2 = "normaalne";
                   }
                   else if (aktiivsused == 3)
                   {
                        aktiivsused2 = "suur";
                    }
                }
                catch (Exception)
                {
                    continue;
                }
            }


        }
    }
}
