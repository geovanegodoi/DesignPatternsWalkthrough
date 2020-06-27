using System;
using FactoryMethod.Creator.Interface;
using FactoryMethod.Product.Implementation;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Creator.Implementation
{
    public class AirLogistics : BaseLogistics, ILogistics
    {
        public AirLogistics()
        {
        }

        public override ITransport CreateTransport()
        {
            return new Plane();
        }
    }
}
