using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Logger__Delegation
{
    public class MyFile
    {
        public static void LogToFile(string messege)
        {
            string filename = "Log.txt";
            using (StreamWriter writer = new StreamWriter(filename))
            {
                writer.WriteLine(messege);
            }
        }
    }
}
