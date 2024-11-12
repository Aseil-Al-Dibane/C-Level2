using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomAttributesForValidation
{ 
    public class RangeAttribute : Attribute
    {
        public int Max {  get; set; }
        public int Min { get; set; }
        public string errorProvider {  get; set; }

        public RangeAttribute(int min, int max)
        {
            Max = max;
            Min = min;
        }
    }
}
