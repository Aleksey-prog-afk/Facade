using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheater.OurHomeTheater
{
    class OurCD : ICD
    {
        public void Off()
        {
            Console.WriteLine("Выключаем CD");
        }

        public void On()
        {
            Console.WriteLine("Слушаем CD");
        }
    }
}
