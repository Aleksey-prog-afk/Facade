using System;
using System.Collections.Generic;
using System.Text;
using Facade.HomeTheater;
namespace Facade
{
    class Control
    {
        private HomeSystem system;
        public Control(HomeSystem system)
        {
            this.system = system;
        }
        public void StartCD()
        {
            this.system.StartCD();
        }
        public void StartDVD()
        {
            this.system.StartDVD();
        }
        public void StartTuner(string wave)
        {
            this.system.StartTuner(wave);
        }
        public void FinishCD()
        {
            this.system.FinishCD();
        }
        public void FinishDVD()
        {
            this.system.FinishDVD();
        }
        public void FinishTuner()
        {
            this.system.FinishTuner();
        }
    }
}
