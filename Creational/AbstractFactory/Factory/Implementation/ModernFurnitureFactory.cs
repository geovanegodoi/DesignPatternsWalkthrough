using System;
using AbstractFactory.Factory.Interface;
using AbstractFactory.Product.Implementation;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Factory.Implementation
{
    public class ModernFurnitureFactory : IFurnitureFactory
    {
        public ModernFurnitureFactory()
        {
        }

        public IChair CreateChair()
        {
            return new ModernChair();
        }

        public ISofa CreateSofa()
        {
            return new ModernSofa();
        }
    }
}
