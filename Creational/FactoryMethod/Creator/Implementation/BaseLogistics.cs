using System;
using FactoryMethod.Creator.Interface;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Creator.Implementation
{
    public abstract class BaseLogistics : ILogistics
    {
        public BaseLogistics()
        {
        }

        public void PlanDelivery()
        {
            Console.WriteLine("Begin delivery procedure");
            var transport = CreateTransport();
            transport.Deliver();
            Console.WriteLine("End delivery procedure");
        }

        public abstract ITransport CreateTransport();
    }
}
