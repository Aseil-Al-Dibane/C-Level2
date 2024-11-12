using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Console_Level2.Logger__Delegation
{
    public class Logger
    {
        public delegate void LogAction(string message);
        private LogAction _LogAction { get; set; }

        public Logger(LogAction logAction) 
        {
            _LogAction = logAction;
        }

        public void Log(string message) 
        {
            _LogAction(message);
        }
    }
}
