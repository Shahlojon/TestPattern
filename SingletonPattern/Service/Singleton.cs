namespace SingletonPattern.Service;

public class Singleton
{
    //Lazy-реализация

    //public string Date { get; private set; }
    //public static string text = "hello";
    //private Singleton()
    //{
    //    Console.WriteLine($"Singleton ctor {DateTime.Now.TimeOfDay}");
    //    Date = DateTime.Now.TimeOfDay.ToString();
    //}

    //public static Singleton GetInstance()
    //{
    //    Console.WriteLine($"GetInstance {DateTime.Now.TimeOfDay}");
    //    return Nested.instance;
    //}

    //private class Nested
    //{
    //    internal static readonly Singleton instance = new Singleton();
    //}

    //Реализация через класс Lazy<T>


    private static readonly Lazy<Singleton> lazy =
        new Lazy<Singleton>(() => new Singleton());

    public string Name { get; private set; }

    private Singleton()
    {
        Name = Guid.NewGuid().ToString();
    }

    public static Singleton GetInstance()
    {
        return lazy.Value;
    }
}
