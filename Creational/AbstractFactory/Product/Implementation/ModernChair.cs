using System;
using AbstractFactory.Product.Interface;

namespace AbstractFactory.Product.Implementation
{
    public class ModernChair : BaseChair, IChair
    {
        public ModernChair() : base("Modern")
        {
        }

        public override bool HasLegs()
        {
            return false;
        }
    }
}
