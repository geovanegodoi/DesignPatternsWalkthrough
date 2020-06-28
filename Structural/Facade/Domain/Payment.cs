using System;
namespace Facade.Domain
{
    public class Payment
    {
        public string CreditCard { get; set; }
        public decimal Value { get; set; }
        public string Status { get; set; }
    }
}
