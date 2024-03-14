namespace CommandPattern.ServicePattern.CommandPatternRealized;

public class Client
{
    void Main()
    {
        Invoker invoker = new Invoker();
        Receiver receiver = new Receiver();
        ConcreateCommand command = new ConcreateCommand(receiver);
        invoker.SetCommand(command);
        invoker.Run();
    }
}
