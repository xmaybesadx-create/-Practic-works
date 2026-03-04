using System;
using System.Collections.Generic;
using System.Text;

namespace Practic_2
{
    public class AirConditioner
    {
        Sensor _sensor;
        public AirConditioner(Sensor sensor)
        {
            _sensor = sensor;
            _sensor.TemperatureChanged += OnTemperatureChanged;
        }

        private void OnTemperatureChanged(object? sender, TemperatureEventArgs e)
        {
            int temperature = e.Temperature;

            if (temperature < 17)
            {
                Console.WriteLine(" [AirConditioner] Увiмкнути обiгрiв");
            }
            else if (temperature > 17 && temperature < 25)
            {
                Console.WriteLine(" [AirConditioner] Кондицiонер вимкнено");
            }
            else if (temperature > 25)
            {
                Console.WriteLine("[AirConditioner] Увiмкнути охолодження");
            }
          
        }
    }

}
