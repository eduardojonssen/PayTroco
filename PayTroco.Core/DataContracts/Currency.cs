using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.DataContracts {
    public class Currency {

        public Currency() {

        }

        public string Name { get; set; }
        public Dictionary<int, int> CurrencyDictionary { get; set; }

    }
}
