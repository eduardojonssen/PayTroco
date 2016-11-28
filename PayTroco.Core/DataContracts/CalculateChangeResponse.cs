using System;
using System.Collections.Generic;

namespace PayTroco.Core.DataContracts {
    public class CalculateChangeResponse : AbstractResponse {
        public CalculateChangeResponse() : base() {
            this.CurrencyCollection = new List<Currency>();
        }
        
        public List<Currency> CurrencyCollection { get; set; }
        public Nullable<int> ChangeAmount { get; set; }

    }
}
