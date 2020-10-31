using System;
using System.Collections.Generic;

namespace Composite
{
    public class Composite : Component
    {
        private readonly List<Component> _children = new List<Component>();

        public Composite()
        {
        }

        public override void Add(Component component)
        {
            this._children.Add(component);
        }

        public override void Remove(Component component)
        {
            this._children.Remove(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override int Operation()
        {
            var total = 0;

            foreach (var child in _children)
            {
                total += child.Operation();
            }

            return total;
        }
    }
}
