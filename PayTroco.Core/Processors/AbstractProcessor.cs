using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
    public abstract class AbstractProcessor {

        public AbstractProcessor() {

        }

        internal abstract int[] GetAvailableValues();

        internal abstract string GetName();
        
        internal virtual ProcessorResult Process (int changeAmount) {

            ProcessorResult processorResult = new ProcessorResult();

            int restChange = changeAmount;

            int[] availableValues = this.GetAvailableValues();

            foreach (int availableValue in availableValues.OrderByDescending(x => x)) {
                if (restChange > 0) {
                    if (restChange / availableValue > 0) {
                        processorResult.ResultDictionary.Add(availableValue, restChange / availableValue);
                        restChange = restChange % availableValue;
                    }
                }
            }

            processorResult.RestChangeInCents = restChange;

            return processorResult;
        }

    }
}
