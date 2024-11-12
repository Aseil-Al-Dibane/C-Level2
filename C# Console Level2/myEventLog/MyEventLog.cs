using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myEventLog
{
    public class MyEventLog
    {
        public enum eventLogEntryType { Error = 1, Warning = 2, Information = 4, SuccessAudit = 8,
        FailureAudit = 16
        };

        public static bool SourceExists(string sourceName)
        {
            return EventLog.SourceExists(sourceName);
        }

        public static void CreateEventSource(string sourceName, string logName)
        {
            EventLog.CreateEventSource(sourceName, logName);
        }

        public static void WriteEntry(string sourceName, string messege, eventLogEntryType type, 
            int eventID = 0) 
        {
            EventLog.WriteEntry(sourceName, messege, (EventLogEntryType)type, eventID);
        }
    }
}
