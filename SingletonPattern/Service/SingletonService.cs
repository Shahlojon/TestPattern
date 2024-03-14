namespace SingletonPattern.Service;

public class SingletonService
{
    private static SingletonService instanse;

    public SingletonService()
    {
    }

    public static SingletonService GetInstanse()
    {
        if(instanse == null)
            instanse = new SingletonService();
        return instanse;
    }
}
