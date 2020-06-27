using System;
namespace AbstractFactory.Product.Interface
{
    public interface ISofa
    {
        string GetStyle();
        bool HasLegs();
        void SeatOn();
    }
}
