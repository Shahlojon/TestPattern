using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter.Service;

public class Subscriber : IObserver
{
    public string name;
    public Subscriber(string name)
    {
        this.name = name;
    }
    public void SendMessageSubscriber(string message)
    {
        Console.WriteLine($"{name} is change {message}");
    }
}
