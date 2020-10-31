using System;
namespace Observer
{
    public interface ISubject
    {
        // Attach an observer to the subject.
        void Subscribe(IObserver observer);

        // Detach an observer from the subject.
        void Unsubscribe(IObserver observer);

        // Notify all observers about an event.
        void Notify();
    }
}
