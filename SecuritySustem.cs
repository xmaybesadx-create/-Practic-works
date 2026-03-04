using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_2
{
    public class SecuritySystem
    {
        Sensor _sensor;
        public SecuritySystem(Sensor sensor)
        {
            _sensor = sensor;
            _sensor.TemperatureChanged += OnTemperatureChanged;
        }

        public void OnTemperatureChanged(object? sender, TemperatureEventArgs e)
        {
            int temperature = e.Temperature;

            if (temperature > 40)
            {
                Console.WriteLine("[Security] Обережно! Висока температура!");
            }
            else if (temperature < 5)
            {
                Console.WriteLine("[Security] Обережно! Низька температура!");
               
            }
         
        }
    }
}






