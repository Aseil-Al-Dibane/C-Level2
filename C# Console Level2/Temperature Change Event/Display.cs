using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2
{
    public class Display
    {
        public void Subscribe(Thermostat thermostat)
        {
            thermostat.TemperatureChanged += HandleTemperatureChange;
        }

        public void HandleTemperatureChange(object sender, TemperatureChangedEventArgs e)
        {
            Console.WriteLine();
            Console.WriteLine($"Old Temperature is : {e.OldTemperature}°C");
            Console.WriteLine($"New Temperature is : {e.NewTemperature}°C");
            Console.WriteLine($"Difference is : {e.Difference}°C");
            Console.WriteLine();
        }
    }
}
