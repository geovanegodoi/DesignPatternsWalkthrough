using System;
using System.Linq;
using Facade.Domain;
using Facade.Service.Interface;

namespace Facade.Service.Implementation
{
    public class CreditCardPaymentService : IPaymentService
    {
        private readonly ICreditCardPaymentFacade _creditCardPaymentFacade;

        public CreditCardPaymentService(ICreditCardPaymentFacade creditCardPaymentFacade)
        {
            _creditCardPaymentFacade = creditCardPaymentFacade;
        }

        public Payment ExecutePayment(Order order, Payment payment)
        {
            payment.Value = order.Products.Sum(o => o.Value);

            if (_creditCardPaymentFacade.ExecutePayment(order, payment))
            {
                payment.Status = "Payment completed through credit card";
                return payment;
            }
            else
            {
                payment.Status = "Credit card rejected !";
                return payment;
            }
        }
    }
}
