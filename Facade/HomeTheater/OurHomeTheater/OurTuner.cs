using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheater.OurHomeTheater
{
    class OurTuner : ITuner
    {
        public void Listen(string wave)
        {
            Console.WriteLine("Слушаем волну " + wave);
        }

        public void Off()
        {
            Console.WriteLine("Выключаем радио");
        }
    }
}
