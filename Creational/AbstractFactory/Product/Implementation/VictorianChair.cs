using System;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product.Implementation
{
    public class VictorianChair : BaseChair, IChair
    {
        public VictorianChair() : base("Victorian")
        {
        }

        public override bool HasLegs()
        {
            return true;
        }
    }
}
