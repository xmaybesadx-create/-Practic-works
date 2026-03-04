using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_2
{
    public class Sensor
    {
        public event EventHandler<TemperatureEventArgs>? TemperatureChanged;
        private int _temperature;
        public int Temperature => _temperature;

        public void SetTemperature(int newTemperature)
        {
            if (_temperature == newTemperature)
            {
                return;
            }
            _temperature = newTemperature;
            Console.WriteLine("Температура задана: ");
            TemperatureChanged?.Invoke(this, new TemperatureEventArgs(_temperature));
        }
    }
}
