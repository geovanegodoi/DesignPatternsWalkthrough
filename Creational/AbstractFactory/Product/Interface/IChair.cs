using System;
namespace AbstractFactory.Product.Interface
{
    public interface IChair
    {
        string GetStyle();
        bool HasLegs();
        void SeatOn();
    }
}
