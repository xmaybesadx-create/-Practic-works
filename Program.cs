using Practic_2;

internal class Program
{
    static void Main()
    {
        Sensor sensor = new Sensor();

      
        Display display = new Display(sensor);
        AirConditioner ac = new AirConditioner(sensor);
        SecuritySystem security = new SecuritySystem(sensor);

       
        sensor.SetTemperature(4);
        Console.WriteLine("----");
        sensor.SetTemperature(20);
        Console.WriteLine("----");
        sensor.SetTemperature(30);
        Console.WriteLine("----");
        sensor.SetTemperature(45);
    }
}