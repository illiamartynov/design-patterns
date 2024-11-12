// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver : IObserver
    {
        public string UserName { get; private set; }

        public ConcreteObserver(string userName)
        {
            UserName = userName;
        }

        public void Update(string availability)
        {
            Console.WriteLine($"wasup {UserName}, product is now {availability} on the store");
        }

        public void AddSubscriber(ISubject subject)
        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(ISubject subject)
        {
            subject.RemoveObserver(this);
        }
    }
}
