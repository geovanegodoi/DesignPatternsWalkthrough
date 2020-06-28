using System;
using Facade.Domain;

namespace Facade.Service.Interface
{
    public interface ICreditCardPaymentFacade
    {
        bool ExecutePayment(Order order, Payment payment);
    }
}
