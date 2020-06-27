using System;
using AbstractFactory.Factory.Interface;
using AbstractFactory.Product.Implementation;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Factory.Implementation
{
    public class VictorianFurnitureFactory : IFurnitureFactory
    {
        public VictorianFurnitureFactory()
        {
        }

        public IChair CreateChair()
        {
            return new VictorianChair();
        }

        public ISofa CreateSofa()
        {
            return new VictorianSofa();
        }
    }
}
