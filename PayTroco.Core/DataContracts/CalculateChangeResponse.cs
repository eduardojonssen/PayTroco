using System.Collections.Generic;

namespace PayTroco.Core.DataContracts {
    public class CalculateChangeResponse : AbstractResponse {
        public CalculateChangeResponse() : base() {

        }

        public Change Change { get; set; }
    }
}
