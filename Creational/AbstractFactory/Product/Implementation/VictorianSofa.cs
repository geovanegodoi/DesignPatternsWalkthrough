using System;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product.Implementation
{
    public class VictorianSofa : BaseSofa, ISofa
    {
        public VictorianSofa() : base("Victorian")
        {
        }

        public override bool HasLegs()
        {
            return true;
        }
    }
}
