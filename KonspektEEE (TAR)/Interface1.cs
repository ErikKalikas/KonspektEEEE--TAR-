using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonspektEEE__TAR_
{
    internal interface Interface1
    {
        /*
         
         5. Тема: Интерфейс (Interface)
         Введение: Интерфейс — это своего рода строгий договор. Он определяет только то, что класс должен уметь делать, но не то, как он это делает. В отличие от абстрактного класса, один класс может реализовывать несколько интерфейсов.

         ✅ Шаг 5: Создадим интерфейс для расчета заработной платы

         */

        public interface ITööline
        {
            double ArvutaPalk(); // Ainult meetodi allkiri
        }
    }
}
