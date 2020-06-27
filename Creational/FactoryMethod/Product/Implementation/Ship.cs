using System;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Product.Implementation
{
    public class Ship : ITransport
    {
        public Ship()
        {
        }

        public void Deliver()
        {
            Console.WriteLine("Deliver by sea in a container");
        }
    }
}
