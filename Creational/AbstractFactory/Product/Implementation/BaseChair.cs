using System;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product.Implementation
{
    public abstract class BaseChair : IChair
    {
        protected readonly string Style;

        public BaseChair(string style)
        {
            Style = style;
            Console.WriteLine($"Creating a {Style} chair");
        }

        public abstract bool HasLegs();


        public virtual void SeatOn()
        {
            Console.WriteLine($"Seatting on a {Style} chair");
        }

        public virtual string GetStyle()
        {
            return Style;
        }
    }
}
