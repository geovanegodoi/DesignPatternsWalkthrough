using System;
using Facade.CrossCutting.Interface;
using Facade.Domain;
using Facade.Service.Interface;

namespace Facade.Service.Implementation
{
    public class CreditCardPaymentFacade : ICreditCardPaymentFacade
    {
        private readonly IPaypalGateway _paypalGateway;
        private readonly IConfigurationManager _configurationManager;

        public CreditCardPaymentFacade(IPaypalGateway paypalGateway, IConfigurationManager configurationManager)
        {
            _paypalGateway = paypalGateway;
            _configurationManager = configurationManager;
        }

        public bool ExecutePayment(Order order, Payment payment)
        {
            var apiKey = _configurationManager.GetApiKey();
            var encKey = _configurationManager.GetEncriptionKey();

            var serviceKey = _paypalGateway.GetServiceKey(apiKey, encKey);
            var cardHashKey = _paypalGateway.GetCardHashKey(serviceKey, payment.CreditCard);

            var paymentResult = _paypalGateway.CommitTransaction(cardHashKey, order.Id.ToString(), payment.Value);

            return paymentResult;
        }
    }
}
