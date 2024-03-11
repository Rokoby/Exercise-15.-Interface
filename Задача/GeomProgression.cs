using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача
{
    class GeomProgression : Interface
    {
        int step;
        int firstValue;
        int currentValue;
        public int GetNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void Reset()
        {
            currentValue = firstValue;
        }

        public void SetStart(int firstValue)
        {
            this.firstValue = firstValue;
            currentValue = firstValue;
        }
        public void SetStep(int step)
        {
            this.step = step;
        }
    }
}