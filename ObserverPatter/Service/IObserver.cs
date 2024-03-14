using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatter.Service;

public interface IObserver
{
    public void SendMessageSubscriber(string message);
}
