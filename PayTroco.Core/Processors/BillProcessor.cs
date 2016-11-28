using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
    internal class BillProcessor : AbstractProcessor {

        public BillProcessor() {

        }

        internal override int[] GetAvailableValues() {

            int[] values = { 10000, 5000, 2000, 1000, 500, 200 };
            return values;

        }

        internal override string GetName() {
            string name = "Bill";
            return name;
        }
    }
}
