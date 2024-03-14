using System.Xml.Linq;

namespace SingletonPattern.Service;

public class Computer
{
    public OS OS { get; set; }

    public void Launch(string osName)
    {
        OS = OS.GetInstance(osName);
    }
}
