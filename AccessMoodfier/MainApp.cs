using System;

namespace AccessMoodfier
{
    class WaterHeater
    {
        projected int temperaature;

        public void SetTemperature(int temperature;
        {
            if (temperature< -5 || temperature> 42 )
            {
                throw new Exception("Out of temperature range");
            }
           
            this.temperature= temperature;
        }
    
        internal void TurnOnWater()
        {
             Console.WriteLine($"Turn On Water : {temperature}");
        }
    }
class MainApp
{
    static void Main(string[] args)
    {
        try
        {
            WaterHeater heater = new WaterHeater();
            heater.SetTemperature(29);
            heater.TurnOnWater();

            heater.SetTemperature(-2);
            heater.TurnOnWater();
        }
        catch (Exception e0
        {
            Console.WriteLine(e.Message)
        }
    }
}

       