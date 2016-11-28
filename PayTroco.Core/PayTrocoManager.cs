using PayTroco.Core.DataContracts;
using System.Collections.Generic;
using System;
using PayTroco.Core.Processors;
using System.Linq;

namespace PayTroco.Core {
    public class PayTrocoManager
    {
        List<AbstractProcessor> processorsCollection;

        public PayTrocoManager() {
            processorsCollection = new List<AbstractProcessor>();
            processorsCollection.Add(new BillProcessor());
            processorsCollection.Add(new CoinProcessor());
        }

        public CalculateChangeResponse CalculateChange(CalculateChangeRequest request)
        {
            CalculateChangeResponse response = new CalculateChangeResponse();
            
            // Verifica se os dados recebidos são válidos.
            if (request.IsValid == false) {
                response.OperationReport = request.ValidationReport;
                return response;
            }

            response.ChangeAmount = request.InsertedAmountInCents - request.ProductAmountInCents;

            processorsCollection = processorsCollection.OrderByDescending(x => x.GetAvailableValues().Min()).ToList();

            int restChange = response.ChangeAmount.Value;
            ProcessorResult processorResult;

            List<Currency> currencyCollection = new List<Currency>();

            foreach (AbstractProcessor processor in processorsCollection) {
                processorResult = processor.Process(restChange);
                restChange = processorResult.RestChangeInCents;
                Currency currency = new Currency();
                currency.Name = processor.GetName();
                currency.CurrencyDictionary = processorResult.ResultDictionary;
                currencyCollection.Add(currency);
            }

            response.Success = true;
            return response;
        }
    }
}
