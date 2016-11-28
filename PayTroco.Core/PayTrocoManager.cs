using PayTroco.Core.DataContracts;
using System.Collections.Generic;
using System;

namespace PayTroco.Core {
    public class PayTrocoManager
    {
        int[] coins = { 100, 50, 25, 10, 5, 1 };

        List<Currency> currencyCollection;

        public PayTrocoManager() {
            currencyCollection = new List<Currency>();
        }

        public CalculateChangeResponse CalculateChange(CalculateChangeRequest request)
        {
            CalculateChangeResponse response = new CalculateChangeResponse();

            // Verifica se os dados recebidos são válidos.
            if (request.IsValid == false) {
                response.OperationReport = request.ValidationReport;
                return response;
            }

            response.Change = new Change();
            response.Change.ChangeAmount = request.InsertedAmountInCents - request.ProductAmountInCents;

            int restChange = response.Change.ChangeAmount.Value;

            foreach (int coin in coins) {
                if (restChange > 0) {
                    if (restChange / coin > 0) {
                        response.Change.ChangeDictionary.Add(coin, restChange / coin);
                        restChange = restChange % coin;
                    } 
                }
            }

            response.Success = true;
            return response;
        }
    }
}
