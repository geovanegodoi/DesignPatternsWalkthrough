using System;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product.Implementation
{
    public class ModernSofa : BaseSofa, ISofa
    {
        public ModernSofa() : base("Modern")
        {
        }

        public override bool HasLegs()
        {
            return false;
        }
    }
}
