using System;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Creator.Interface
{
    public interface ILogistics
    {
        void PlanDelivery();
        ITransport CreateTransport();
    }
}
