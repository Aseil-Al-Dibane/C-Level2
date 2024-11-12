using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2
{
    public class Thermostat
    {
        public event EventHandler<TemperatureChangedEventArgs> TemperatureChanged;
        public int OldTemperature { get; set; }
        public int CurrentTemperature { get; set; } = 0;

        public void SetTemperature(int NewTemperature)
        {
            if (CurrentTemperature != NewTemperature)
            {
                OldTemperature = CurrentTemperature;
                CurrentTemperature = NewTemperature;
                RaiseTemperatureChanged(OldTemperature, CurrentTemperature);
            }
        }

        public void RaiseTemperatureChanged(int OldTemperature, int NewTemperature)
        {
            TemperatureChangedEventArgs e = new TemperatureChangedEventArgs(OldTemperature, NewTemperature);
            TemperatureChanged?.Invoke(this, e);
        }
    }
}
