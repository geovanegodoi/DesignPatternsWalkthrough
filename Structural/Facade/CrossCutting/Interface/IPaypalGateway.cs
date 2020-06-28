using System;
namespace Facade.CrossCutting.Interface
{
    public interface IPaypalGateway
    {
        string GetCardHashKey(string serviceKey, string creditCard);
        string GetServiceKey(string apiKey, string encriptionKey);
        bool CommitTransaction(string cardHashKey, string orderId, decimal amount);
    }
}
