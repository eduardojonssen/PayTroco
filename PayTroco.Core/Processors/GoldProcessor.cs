using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
   internal class GoldProcessor: AbstractProcessor {

        public GoldProcessor() {

        }

        internal override int[] GetAvailableValues() {

            int[] values = {1000000, 500000 };
            return values;

        }

        internal override string GetName() {
            string name = "Gold";
            return name;
        }

    }
}
