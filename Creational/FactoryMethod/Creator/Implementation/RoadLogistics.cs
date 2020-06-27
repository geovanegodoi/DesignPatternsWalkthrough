using System;
using FactoryMethod.Creator.Interface;
using FactoryMethod.Product.Implementation;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Creator.Implementation
{
    public class RoadLogistics : BaseLogistics, ILogistics
    {
        public RoadLogistics()
        {
        }

        public override ITransport CreateTransport()
        {
            return new Truck();
        }
    }
}
