using System.Collections.Generic;

namespace PayTroco.Core.DataContracts {
    public abstract class AbstractResponse {

        public AbstractResponse() {
            this.OperationReport = new List<Report>();
        }

        public List<Report> OperationReport { get; set; }
        public bool Success { get; set; }

    }
}
