// In case you need some guidance: https://refactoring.guru/design-patterns/observer

namespace DesignPattern.Observer
{
    public class ConcreteObserver(string userName) : IObserver
    {
        public string UserName { get; private set; } = userName;
        
        public void Update(string availability)
        {
            Console.WriteLine($"For {UserName}: Product is now {availability}");
        }

        public void AddSubscriber(Subject subject)
        {
            subject.RegisterObserver(this);
        }

        public void RemoveSubscriber(Subject subject)
        {
            subject.RemoveObserver(this);
        }
    }
}
