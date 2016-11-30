using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayTroco.Core.Processors {
    internal static class ProcessorFactory {

        static List<AbstractProcessor> processorsCollection;

        static ProcessorFactory() {
            processorsCollection = new List<AbstractProcessor>();
            processorsCollection.Add(new BillProcessor());
            processorsCollection.Add(new CoinProcessor());
            processorsCollection.Add(new CandyProcessor());
            processorsCollection.Add(new SilverProcessor());
            processorsCollection.Add(new GoldProcessor());

            //Adicionar novos processadores acima desta linha
        }
        internal static AbstractProcessor Create(int changeAmount) {
            
            foreach (AbstractProcessor processor in processorsCollection.OrderByDescending(x => x.GetAvailableValues().Min()).ToList()) {
                if(changeAmount >= processor.GetAvailableValues().Min()) {
                    return processor;
                }
            }
            
            return null;
        }

    }
}
