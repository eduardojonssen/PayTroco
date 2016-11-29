using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
    internal class SilverProcessor : AbstractProcessor {

        public SilverProcessor() {

        }

        internal override int[] GetAvailableValues() {

            int[] values = { 100000, 50000 };
            return values;
      
        }

        internal override string GetName() {
            string name = "Silver";
            return name;
        }
    }

}
