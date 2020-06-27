using System;
using FactoryMethod.Creator.Interface;
using FactoryMethod.Product.Implementation;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Creator.Implementation
{
    public class SeaLogistics : BaseLogistics, ILogistics
    {
        public SeaLogistics()
        {
        }

        public override ITransport CreateTransport()
        {
            return new Ship();
        }
    }
}
