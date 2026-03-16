using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace KonspektEEE__TAR_
{
    class Person //3
    {
        public string Name { get; set; }
    }
    class Toode //Ülesanne 1
    {
        public string Nimi { get; set; }
    }
    class Inimene //Ülesanne 1
    {
        public string Nimi { get; set; }
        public int Vanus { get; set; }
        public string Sugu { get; set; }
        public char Pikkus { get; set; }
        public string Kaal { get; set; }
        public string Aktiivsustase { get; set; }
        
    }

    internal class ClassOsa5
    {
        public static void teoria()
        {
            //1. ArrayList (System.Collections)

            /* 
            ArrayList — это простой способ сбора данных, размер которого не нужно задавать заранее. Он автоматически адаптируется к количеству добавляемых элементов. 
             
            Add() – добавляет элемент в конец списка

            Contains() – проверяет наличие элемента

            Count – возвращает количество элементов

            Insert(index, item) – добавляет элемент в указанное место

            IndexOf() – ищет индекс элемента

            Sort() – сортирует элементы по возрастанию
             */


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

            /*
             Add(item) — добавляет один элемент item в конец списка.

             AddRange(collection) — добавляет несколько элементов из коллекции collection в конец списка.

             IndexOf(item) — возвращает индекс первого найденного элемента item в списке (или -1, если элемент не найден).

             Remove(item) — удаляет первый найденный элемент item из списка.

             RemoveAt(index) — удаляет элемент по указанному индексу index.

             Insert(index, item) — добавляет элемент item на указанную позицию index в списке.

             Sort() — сортирует элементы списка по возрастанию.

             BinarySearch(item) — выполняет быстрый поиск элемента item в отсортированном списке и возвращает его индекс (если не найден — возвращает отрицательное число).
             */

            //Näide:


            List<Person> people = new List<Person>();
              people.Add(new Person() { Name = "Kadi" });
              people.Add(new Person() { Name = "Mirje" });

              foreach (Person p in people)
              Console.WriteLine(p.Name);



            //4. LinkedList (System.Collections.Generic)
            //Структура данных, организованная в виде списка. Хорошо подходит, если часто требуется добавлять или удалять элементы в начале или в середине списка.

            /*
              AddFirst(value) — добавляет элемент value в начало LinkedList.

              AddLast(value) — добавляет элемент value в конец LinkedList.

              AddBefore(node, value) — добавляет элемент value перед указанным узлом node в LinkedList.

              AddAfter(node, value) — добавляет элемент value после указанного узла node в LinkedList.

              RemoveFirst() — удаляет первый элемент из LinkedList.

              RemoveLast() — удаляет последний элемент из LinkedList.

              Remove(value) — удаляет первый найденный элемент со значением value из LinkedList.

             */
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

            /*
             Add(key, value) — добавляет пару ключ-значение (key — ключ, value — значение) в Dictionary.

             Remove(key) — удаляет элемент из Dictionary по указанному ключу key.

             ContainsKey(key) — проверяет, существует ли указанный ключ key в Dictionary (возвращает true или false).

             ContainsValue(value) — проверяет, есть ли в Dictionary указанное значение value.

             Keys — возвращает коллекцию всех ключей в Dictionary.

             Values — возвращает коллекцию всех значений в Dictionary.
             */

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
            List<Inimene> inimene1 = new List<Inimene>();
            List<Toode> Toode1 = new List<Toode>();

            Console.WriteLine("kirjutage toote nimi");
            string toote = Console.ReadLine();
            Toode1.Add(new Toode() { Nimi = toote });


            Console.WriteLine("kuidas sinu nimi?");
            string nimi = Console.ReadLine();
            inimene1.Add(new Inimene() { Nimi = nimi });

            Console.WriteLine("Kui vana sa oled?");
            int vanus = int.Parse(Console.ReadLine());
            inimene1.Add(new Inimene() { Vanus = vanus });

            Console.WriteLine("Milline on su sugu?");
            string sugu = Console.ReadLine();
            inimene1.Add(new Inimene() { Sugu = sugu });

            Console.WriteLine("Kui pikk sa oled? (arv.arv)m");
            char Pikkus = char.Parse(Console.ReadLine());
            inimene1.Add(new Inimene() { Pikkus = Pikkus });

            Console.WriteLine("Milline on sinu aktiivsusaste? (0%>, <100%) ");
            
        }
    }
}
