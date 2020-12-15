using System;
using System.Collections.Generic;
using System.Text;

namespace Facade.HomeTheater
{
    class HomeSystem
    {
        protected IAmplifier amplifier;
        protected IPopper popper;
        protected IDVD dvd;
        protected ICD cd;
        protected IProjector projector;
        protected IScreen screen;
        protected ISoundSystem soundSystem;
        protected ITuner tuner;
        public HomeSystem(
            IAmplifier amplifier,
            IPopper popper,
            IDVD dvd,
            ICD cd,
            IProjector projector,
            IScreen screen,
            ISoundSystem soundSystem,
            ITuner tuner
            )
        {
            this.amplifier = amplifier;
            this.popper = popper;
            this.dvd = dvd;
            this.cd = cd;
            this.projector = projector;
            this.screen = screen;
            this.soundSystem = soundSystem;
            this.tuner = tuner;
        }
        public void StartCD()
        {
            this.cd.On();
        }
        public void FinishCD()
        {
            this.cd.Off();
        }
        public void StartDVD()
        {
            this.dvd.On();
        }
        public void FinishDVD()
        {
            this.dvd.Off();
        }
        public void StartTuner(string wave)
        {
            this.tuner.Listen(wave);
        }
        public void FinishTuner()
        {
            this.tuner.Off();
        }
    }
}
