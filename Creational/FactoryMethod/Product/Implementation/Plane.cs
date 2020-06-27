using System;
using FactoryMethod.Product.Interface;

namespace FactoryMethod.Product.Implementation
{
    public class Plane : ITransport
    {
        public Plane()
        {
        }

        public void Deliver()
        {
            Console.WriteLine("Deliver by air in a container");
        }
    }
}
