using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject = new Subject();
            var observerA = new ConcreteObserverA();
            var observerB = new ConcreteObserverB();

            subject.SomeBusinessLogic();

            subject.Subscribe(observerA);            

            subject.Subscribe(observerB);

            subject.SomeBusinessLogic();

            subject.SomeBusinessLogic();

            subject.Unsubscribe(observerB);

            subject.SomeBusinessLogic();
        }
    }
}
