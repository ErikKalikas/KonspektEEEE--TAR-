using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    /*
     🔐 2. Тема: Инкапсуляция (Encapsulation)
    Введение: Инкапсуляция означает сокрытие данных и их защиту от неправомерного использования.
    Мы не хотим, чтобы кто-то мог, например, указать возраст -5.
    Для этого мы делаем данные приватными и предоставляем к ним доступ через контролируемые свойства (Properties).

    ✅ Шаг 2: Обновим класс Isik с помощью инкапсуляции
     */

    /* public class Isik
       {
           // Privaatne väli - otse ligi ei saa                        // Частное поле — прямой доступ запрещен
           private int sünniaasta;

           // Avalik omadus (Property) automaatse get/set logikaga     // Публичное свойство (Property) с автоматической логикой get/set
           public string Nimi { get; set; }

           // Kontrollitud omadus                                          // Проверяемое свойство
           public int Sünniaasta
           {
               get { return sünniaasta; }
               set{

                   if (value > 1900 && value <= DateTime.Now.Year)
                   {
                       sünniaasta = value;
                   }                  
                   else
                   {
                       Console.WriteLine("Vigane sünniaasta!");
                   }

               }
           }

           // Arvutatud omadus (ainult lugemiseks / getter)                // Вычисляемое свойство (только для чтения / getter)
           public int Vanus => DateTime.Now.Year - sünniaasta;
       }
    */

    //------------------------------------------------------------

    /*
         🎯 Вывод: Абстрактный класс — это как незавершённый чертеж,
         на основе которого нельзя сразу создать объект.
         Он закладывает основу и требует, чтобы подклассы довели дело до конца (например, определили, как работает метод «Описать()»).
     */


    public abstract class Isik
    {
        public string Nimi { get; set; }

        // Abstraktne meetod – sisu puudub, alamklassid PEAVAD selle ise looma
        public abstract void Kirjelda();
    }



    /*
        🎯 Вывод: Капсулирование защищает внутреннее состояние объекта.
        Для хранения данных используйте частные поля,
        а для их чтения/изменения — публичные свойства get/set.
     */
}
