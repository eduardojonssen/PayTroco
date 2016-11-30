using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PayTroco.Core.Logger {
    public static class LoggerManager {

        static string path = @"C:\Logs\";
        static string filename = @"PayTroco.log";
        
        /// Summary 
        /// Este método irá criar logs da aplicação.
        /// Variáveis de entrada:
        ///     - message: mensagem de log
        ///     - method: método que chama o log
        ///     - type: response, request ou exception
        ///     - category: info, error, debug, warning, panic
        internal static void Log(string message, string method, string type, string category = "Info") {
            Directory.CreateDirectory(path);
            using (StreamWriter stream = new StreamWriter(path + filename, true)) {
                message = DateTime.Now + "||" + method + "||" + category + "||" + type + "||" + message;
                stream.WriteLine(message);
            }
        }

    }
}
