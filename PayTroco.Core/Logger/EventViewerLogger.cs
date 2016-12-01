using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Logger {
    internal class EventViewerLogger : AbstractLogger{

        internal EventViewerLogger() : base(){

        }

        internal override void Log(string message, string method, string type, string category) {
            EventLogEntryType eventLogEntryType = EventLogEntryType.Information;

            switch (category) {
                case "Error":
                    eventLogEntryType = EventLogEntryType.Error;
                    break;
            }

            EventLog.WriteEntry("PayTroco", $"{method}: {type}: {message}", eventLogEntryType, 101);
        }
    }
}
