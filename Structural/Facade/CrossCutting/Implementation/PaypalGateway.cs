using System;
using System.Linq;
using Facade.CrossCutting.Interface;

namespace Facade.CrossCutting.Implementation
{
    public class PaypalGateway : IPaypalGateway
    {
        public PaypalGateway()
        {
        }

        public bool CommitTransaction(string cardHashKey, string orderId, decimal amount)
        {
            return new Random().Next(2) == 0;
        }

        public string GetCardHashKey(string serviceKey, string creditCard)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }

        public string GetServiceKey(string apiKey, string encriptionKey)
        {
            return new string(Enumerable.Repeat("ABCDEFGHIJKLMNOPQRSTUWXYZ0123456789", 10)
                .Select(s => s[new Random().Next(s.Length)]).ToArray());
        }
    }
}
