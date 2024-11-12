using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Class
{
    public class CustomEventArgs
    {
        public string FileName { get; set; }

        public CustomEventArgs(string fileName)
        {
            FileName = fileName;
        }
    }
}
