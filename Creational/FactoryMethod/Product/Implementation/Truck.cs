using System;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Product.Implementation
{
    public class Truck : ITransport
    {
        public Truck()
        {
        }

        public void Deliver()
        {
            Console.WriteLine("Deliver by land in a box");
        }
    }
}
