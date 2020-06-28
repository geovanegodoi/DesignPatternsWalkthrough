using System;
using System.Collections.Generic;

namespace Facade.Domain
{
    public class Order
    {
        public Guid Id { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}
