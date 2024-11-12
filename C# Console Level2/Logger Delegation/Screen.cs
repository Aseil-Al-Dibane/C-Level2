using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Logger__Delegation
{
    public class Screen
    {
        public static void LogToScreen(string messege)
        {
            Console.WriteLine($"Messege in screen : {messege}");
        }
    }
}
