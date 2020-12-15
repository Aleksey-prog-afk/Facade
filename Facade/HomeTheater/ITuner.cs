using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheater
{
    interface ITuner
    {
        void Listen(string wave);
        void Off();
    }
}
