using System;
namespace Composite
{
    public class Leaf : Component
    {
        private readonly int _value = 0;

        public Leaf(int value)
        {
            _value = value;
        }

        public override bool IsComposite()
        {
            return false;
        }

        public override int Operation()
        {
            return _value;
        }
    }
}
