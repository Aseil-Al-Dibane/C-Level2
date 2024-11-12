using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionWithCustomAttributes
{
    [MyCustom("This is a class attribute")]
    public class myClass
    {
        [MyCustom("This is a method attribute")]
        public static void MyMethod()
        {
            // Method implementation
        }
    }
}
