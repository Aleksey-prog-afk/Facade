using Facade.HomeTheater;
using Facade.HomeTheater.OurHomeTheater;
using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeSystem system = new HomeSystem(
                new OurAmplifier(),
                new OurPopper(),
                new OurDVD(),
                new OurCD(),
                new OurProjector(),
                new OurScreen(),
                new OurSoundSystem(),
                new OurTuner()
             );
            Control control = new Control(system);
            control.StartCD();
            control.StartDVD();
            control.StartTuner("13/77");
            control.FinishDVD();
            control.FinishTuner();
            control.FinishCD();
        }
    }
}
