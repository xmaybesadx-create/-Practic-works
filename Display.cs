using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_2
{
    public class Display
    {
        Sensor _sensor;

        public Display(Sensor sensor)
        {
            _sensor = sensor;
            _sensor.TemperatureChanged += OnTemperatureChanged;
        }

        public void OnTemperatureChanged(object? sender, TemperatureEventArgs e)
        {
      
            Console.WriteLine($"[Display] Температура змiнилася: {e.Temperature} C");
           
        }
    }
}
