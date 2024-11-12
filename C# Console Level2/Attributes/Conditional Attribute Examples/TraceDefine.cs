using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Conditional_Attribute_Examples
{
    public class TraceDefine
    {
        [Conditional("TracingMode_On")]
        public static void TraceModeOnMethod1()
        {
            Console.WriteLine();
            Console.WriteLine(@"Method1 : This messege appears because the [TracingMode_On] conditional is defined in Main Page");
            Console.WriteLine();
        }

        [Conditional("Aseil")]
        public static void TraceModeOnMethod2()
        {
            Console.WriteLine();
            Console.WriteLine(@"Method2 : This messege appears because the [Aseil] conditional is defined
in Properties of this Project --> Build tab --> Conditional compilation symbols");
            Console.WriteLine();
        }

    }
}
