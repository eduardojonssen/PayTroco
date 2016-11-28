using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.DataContracts {
    public class Report {
        public Report() {

        }

        public Report(string field, string message) {
            this.Field = field;
            this.Message = message;
        }

        public string Field { get; set; }
        public string Message { get; set; }

        public override string ToString() {
            return this.Message + "\r\n";
        }

    }
}
