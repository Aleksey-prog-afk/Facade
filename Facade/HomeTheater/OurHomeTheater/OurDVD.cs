using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheater.OurHomeTheater
{
    class OurDVD : IDVD
    {
        public void Off()
        {
            Console.WriteLine("Выключаем DVD");
        }

        public void On()
        {
            Console.WriteLine("Смотрим DVD");
        }
    }
}
