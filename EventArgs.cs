using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_2
{
    public class TemperatureEventArgs : EventArgs
    {
        public int Temperature { get; }

        public TemperatureEventArgs(int temperature)
        {
            Temperature = temperature;
        }
    }
}
