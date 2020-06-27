using System;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product.Implementation
{
    public abstract class BaseSofa : ISofa
    {
        protected readonly string Style;

        public BaseSofa(string style)
        {
            Style = style;
            Console.WriteLine($"Creating a {Style} sofa");
        }

        public abstract bool HasLegs();


        public virtual void SeatOn()
        {
            Console.WriteLine($"Seatting on a {Style} sofa");
        }

        public virtual string GetStyle()
        {
            return Style;
        }
    }
}
