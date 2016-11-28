using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
    internal class ProcessorResult {

        public ProcessorResult() {
            ResultDictionary = new Dictionary<int, int>();
        }

        internal Dictionary<int, int> ResultDictionary;
        internal int RestChangeInCents;

    }
}
