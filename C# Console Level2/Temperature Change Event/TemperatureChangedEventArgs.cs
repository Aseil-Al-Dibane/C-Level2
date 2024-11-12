using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2
{
    public class TemperatureChangedEventArgs : EventArgs
    {
        public int OldTemperature { get; }
        public int NewTemperature { get; }
        public int Difference {  get; } 

        public TemperatureChangedEventArgs(int OldTemperature, int NewTemperature) 
        {
            this.OldTemperature = OldTemperature;
            this.NewTemperature = NewTemperature;
            this.Difference = NewTemperature - OldTemperature;
        }
    }
}
