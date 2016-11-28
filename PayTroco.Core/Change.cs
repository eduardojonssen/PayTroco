using System;
using System.Collections.Generic;

namespace PayTroco.Core {
    public class Change {

        public Change() {
            this.ChangeDictionary = new Dictionary<int, int>();
        }
    
       public Dictionary<int, int> ChangeDictionary { get; set; }
       public Nullable<int> ChangeAmount { get; set; }
    }
}
