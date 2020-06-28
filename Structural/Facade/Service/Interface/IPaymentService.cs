using System;
using Facade.Domain;

namespace Facade.Service.Interface
{
    public interface IPaymentService
    {
        Payment ExecutePayment(Order order, Payment payment);
    }
}
