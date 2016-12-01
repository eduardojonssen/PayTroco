using Dlp.Framework;
using PayTroco.Core.DataContracts;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace PayTroco.Core.Logger {
    public static class LoggerManager {

        public static void Log (object logData, [CallerMemberName]string methodName = null) {
            string logDataJSON = Serializer.NewtonsoftSerialize(logData);
            string type;
            string category = "Info";

            if (logData is AbstractRequest)
                type = "Request";
            else if (logData is AbstractResponse)
                type = "Response";
            else if (logData is Exception) {
                type = "Exception";
                category = "Error";
            }
            else
                type = "Others";

            EventViewerLogger eventViewerLogger = new EventViewerLogger();
            eventViewerLogger.Log(logDataJSON, methodName, type, category);

            FileLogger fileLogger = new FileLogger();
            fileLogger.Log(logDataJSON, methodName, type, category);
        }


    }
}
