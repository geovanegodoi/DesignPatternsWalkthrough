using System;

namespace Observer
{
    public class ConcreteObserverA : IObserver
    {
        public ConcreteObserverA()
        {
        }

        public void Update(ISubject subject)
        {
            if ((subject as Subject).State < 3)
            {
                Console.WriteLine("ConcreteObserverA: Reacted to the event.");
            }
        }
    }
}
