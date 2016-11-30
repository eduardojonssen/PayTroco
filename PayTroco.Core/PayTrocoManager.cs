using PayTroco.Core.DataContracts;
using System.Collections.Generic;
using System;
using PayTroco.Core.Processors;
using PayTroco.Core.Logger;
using System.Linq;
using Dlp.Framework;

namespace PayTroco.Core {
    public class PayTrocoManager {

        public PayTrocoManager() {

        }

        public CalculateChangeResponse CalculateChange(CalculateChangeRequest request) {

            string requestJSON = Serializer.NewtonsoftSerialize(request);
            LoggerManager.Log(requestJSON, "CalculateChange", "Request", "Info");

            CalculateChangeResponse response = new CalculateChangeResponse();
            try {

                // Verifica se os dados recebidos são válidos.
                if (request.IsValid == false) {
                    response.OperationReport = request.ValidationReport;
                    return response;
                }

                int changeAmount = request.InsertedAmountInCents - request.ProductAmountInCents;

                int restChange = changeAmount;
                ProcessorResult processorResult;

                List<Currency> currencyCollection = new List<Currency>();
                AbstractProcessor processor;
                while (restChange > 0) {
                    processor = ProcessorFactory.Create(restChange);
                    if (processor == null) {
                        response.OperationReport.Add(new Report("", "It was not possible to process your request."));
                        return response;
                    }
                    processorResult = processor.Process(restChange);
                    restChange = processorResult.RestChangeInCents;
                    Currency currency = new Currency();
                    currency.Name = processor.GetName();
                    currency.CurrencyDictionary = processorResult.ResultDictionary;
                    currencyCollection.Add(currency);
                }

                response.ChangeAmount = changeAmount;
                response.CurrencyCollection = currencyCollection;
                response.Success = true;
            }
            catch (Exception e) {
                response.OperationReport.Add(new Report("", "Ops! Something went wrong."));
                string exceptionJSON = Serializer.NewtonsoftSerialize(e);
                LoggerManager.Log(exceptionJSON, "CalculateChange", "Exception", "Error");
            } finally {
                string responseJSON = Serializer.NewtonsoftSerialize(response);
                LoggerManager.Log(responseJSON, "CalculateChange", "Response", "Info");
            }

            return response;
        }
    }
}
