using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Logger {
    internal class FileLogger : AbstractLogger{

        public FileLogger() : base(){

        }

        static string path = ConfigurationManager.AppSettings["BaseFileLogPath"];
        static string filename = ConfigurationManager.AppSettings["FileLogName"];


        /// Summary 
        /// Este método irá criar logs da aplicação.
        /// Variáveis de entrada:
        ///     - message: mensagem de log
        ///     - method: método que chama o log
        ///     - type: response, request ou exception
        ///     - category: info, error, debug, warning, panic
        internal override void Log(string message, string method, string type, string category) {
            Directory.CreateDirectory(path);
            using (StreamWriter stream = new StreamWriter(path + filename, true)) {
                message = DateTime.Now + "||" + method + "||" + category + "||" + type + "||" + message;
                stream.WriteLine(message);
            }
        }
    }
}
