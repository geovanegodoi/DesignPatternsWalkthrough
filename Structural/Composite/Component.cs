using System;
namespace Composite
{
    public abstract class Component
    {
        public Component()
        {
        }

        public abstract int Operation();

        public abstract bool IsComposite();

        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(Component component)
        {
            throw new NotImplementedException();
        }
    }
}
