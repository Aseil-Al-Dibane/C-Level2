using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Conditional_Attribute_Examples
{
    public class DebugRelease
    {
        [Conditional("DEBUG")]
        public static void DebugModeMethod()
        {
            Console.WriteLine("This messege is appearing only when compiler in Debug mode");
        }

        public static void Method()
        {
            Console.WriteLine("This messege is appearing anyway");
        }
    }
}
