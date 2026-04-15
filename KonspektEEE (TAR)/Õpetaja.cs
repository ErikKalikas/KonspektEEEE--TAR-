using KonspektEEE__TAR_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static KonspektEEE__TAR_.Interface1;

namespace KonspektEEE__TAR_
{
    /*
     // Õpetaja pärib klassist Isik (koolon tähistab pärimist)            // Учитель задает вопрос классу (двоеточие обозначает вопрос)
        public class Õpetaja : Isik
        {
            public string Aine { get; set; }

            public void Õpeta()
            {
                Console.WriteLine($"{Nimi} õpetab ainet: {Aine}.");
            }
        }
     */

    /*
    public class Õpetaja : Isik
    {
        public string Aine { get; set; }

        // override kirjutab abstraktse meetodi üle
        public override void Kirjelda()
        {
            Console.WriteLine($"Mina olen õpetaja {Nimi} ja ma õpetan: {Aine}.");
        }
    }
    */


    // Õpetaja pärib Isik klassist JA rakendab ITööline liidest               //Учитель запрашивает данные об ученике из класса И использует интерфейс ITööline
    public class Õpetaja : Isik, ITööline
    {
        public double Tunnitasu { get; set; } //Почасовая оплата
        public int TunnidNädalas { get; set; } //Уроки в неделю
        public string Aine { get; set; }

        public override void Kirjelda()
        {
            double b = ArvutaPalk();
            Console.WriteLine($"Õpetaja: {Nimi}. ArvutaPalk: {b}");
        }

        // Kohustuslik meetod liidesest                     //Обязательный метод интерфейса
        public double ArvutaPalk()
        {
            return Tunnitasu * TunnidNädalas * 4; // Kuupalk
        }
    }
}


