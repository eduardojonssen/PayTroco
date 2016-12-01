using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Logger {
    internal abstract class AbstractLogger {


        internal abstract void Log(string message, string method, string type, string category);

    }
}
