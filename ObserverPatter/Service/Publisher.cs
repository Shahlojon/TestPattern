using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter.Service;

public class Publisher : IPublisher
{
    private readonly List<IObserver> observers = new List<IObserver>();

    public void AddObserver(IObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var item in observers)
        {
            item.SendMessageSubscriber(message);
        }
    }

    public void RemoveObserver(IObserver observer)
    {
        observers.Remove(observer);
    }

    // Simulate state change and notify observers
    public void ChangeState()
    {
        Console.WriteLine("Publisher's state is changing...");
        NotifyObservers("State has changed!");
    }
}
