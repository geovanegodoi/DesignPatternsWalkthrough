using System;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Factory.Interface
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ISofa CreateSofa();
    }
}
